﻿namespace TravelAgencyAPP.Interfaces
{
    internal interface IListForm 
    {
        void Add();
        void Edit();
        void Delete();
        void LoadData(IEnumerable<object> data);
    }
}
