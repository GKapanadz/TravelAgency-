﻿using Dapper;
using System.Data;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;
using Humanizer;

namespace TravelAgency.Repositories
{
    internal abstract class BaseRepository<T> : IRepository<T>
    {
        protected readonly IDbConnection _connection;
        protected readonly string _entityName;
        protected readonly Func<IDbTransaction> _getTransaction;

        private IEnumerable<string> InsertIgnoredProperties => 
            new[] {"IsActive", "CreateDate", "UpdateDate", $"{_entityName}ID" };

        private IEnumerable<string> UpdateIgnoredProperties =>
            new[] { "IsActive", "CreateDate", "UpdateDate" };

        protected BaseRepository(IDbConnection connection, Func<IDbTransaction> getTransaction)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
            _entityName = typeof(T).Name;
            _getTransaction = getTransaction;
        }

        public virtual T? Get(object id)
        {
            var parameters = new DynamicParameters();
            parameters.Add($"{_entityName}Id", id);

            return _connection.QueryFirstOrDefault<T>(
                $"sp_Get{_entityName}",
                parameters,
                commandType: CommandType.StoredProcedure, transaction: _getTransaction?.Invoke());
        }

        public virtual object Insert(T value)
        {
            var parameters = new DynamicParameters();
            SetInsertParameters(value, parameters);
            _connection.Execute($"sp_Insert{_entityName}", parameters, commandType: CommandType.StoredProcedure);

            return parameters.Get<object>($"{_entityName}ID");
        }

        public virtual IEnumerable<T> Query(Expression<Func<T, bool>> predicate)
        {
            var (sql, parameters) = SqlExpressionVisitor.ToSql(predicate);

            IEnumerable<string> properties = typeof(T)
                                .GetProperties()
                                .Select(p => p.Name);

            string columns = string.Join(", ", properties);

            if (typeof(T) == typeof(User))
            {
                columns = columns.Replace("Password", "HASHBYTES('SHA2_256', Password)");
            }

            StringBuilder query = new StringBuilder($"SELECT {columns} FROM {_entityName.Pluralize()} WHERE ");
            query.Append(sql);

            return _connection.Query<T>(query.ToString(), parameters);
        }


        public virtual void Update(T value)
        {
          
            var parameters = new DynamicParameters();
            SetUpdateParameters(value, parameters);
            _connection.Execute($"sp_Update{_entityName}", parameters, commandType: CommandType.StoredProcedure, transaction: _getTransaction.Invoke());
        }

        public virtual void Delete(object id)
        {
            var parameters = new DynamicParameters();
            parameters.Add($"{_entityName}ID", id);
            _connection.Execute($"sp_Delete{_entityName}", parameters,  commandType: CommandType.StoredProcedure, transaction: _getTransaction.Invoke());
        }

        private void SetInsertParameters(T value, DynamicParameters parameters)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            parameters.Add($"{_entityName}ID", DbType.Int32, direction: ParameterDirection.Output);
            foreach (var property in properties.Where(p => !InsertIgnoredProperties.Contains(p.Name)))
            {
                parameters.Add(property.Name, property.GetValue(value));
            }
        }

        private void SetUpdateParameters(T value, DynamicParameters parameters)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (var property in properties.Where(p => !UpdateIgnoredProperties.Contains(p.Name)))
            {
                if (value == null && property.PropertyType != typeof(string))
                {
                    continue; 
                }

                parameters.Add(property.Name, property.GetValue(value));
            }
        }
    }
}
