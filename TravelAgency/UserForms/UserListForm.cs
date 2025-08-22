using TravelAgency.DTO;
using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;
using TravelAgencyAPP.Interfaces;
using static TravelAgencyAPP.AddUserForm;

namespace TravelAgencyAPP
{
    public partial class UserListForm : Form, IListForm
    {
        private readonly IUserService _userService;
        private readonly User _user;
        public UserListForm()
        {
            InitializeComponent();
            dataGridViewUser.AutoGenerateColumns = true;

            _userService = UserServiceFactory.Create();
            LoadData(_userService.GetAllUsers());
        }

        public void Add()
        {
            AddUserForm userForm = new AddUserForm();
            userForm.ShowDialog();
        }

        public void Delete()
        {
            if (dataGridViewUser.CurrentRow?.DataBoundItem is not User selectedUser)
            {
                FormHelper.ShowWarning(this, "Please select a tour to delete.");
                return;
            }

            DeleteUserForm deleteForm = new DeleteUserForm(selectedUser);
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                LoadData(_userService.GetAllUsers());
            }
        }

        public void Edit()
        {
            if (dataGridViewUser.CurrentRow == null || dataGridViewUser.CurrentRow.DataBoundItem is not User selectedUser)
            {
                FormHelper.ShowWarning(this, "Please select a tour to edit.");
                return;
            }

            EditUserForm editForm = new EditUserForm(selectedUser);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadData(_userService.GetAllUsers());
            }
        }

        public void LoadData(IEnumerable<object> data)
        {
            UserName.DataPropertyName = "UserName";
            UserRole.DataPropertyName = "UserRole";
            IsActive.DataPropertyName = "IsActive";
            CreateDate.DataPropertyName = "CreateDate";

            dataGridViewUser.DataSource = data.ToList();
        }

        public void Restore()
        {
            throw new NotImplementedException();
        }

        private void txtSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                var searchText = txtSearchBar.Text.Trim().ToLower();
                var searchTextNoSpace = searchText.Replace(" ", "");

                var searchedItems = _userService.GetUsersByName("")
                    .Where(item =>
                    {
                        var name = item.UserName.ToLower();
                        var nameNoSpace = name.Replace(" ", "");

                        return name.Contains(searchText) || nameNoSpace.Contains(searchTextNoSpace)
                            || item.UserRole.ToString().Contains(searchText)
                            || item.IsActive.ToString().Contains(searchText)
                            || item.CreateDate.ToString().Contains(searchText)
                            || item.UserID.ToString().Contains(searchText);
                    });

                LoadData(searchedItems);
            }
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Clear();
        }

        private void dataGridViewUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewUser.Columns[e.ColumnIndex].DataPropertyName == "IsActive")
            {
                if (e.Value is bool isActive)
                {
                    e.Value = isActive ? "Active" : "Inactive";
                    e.FormattingApplied = true;
                }
            }

            if (dataGridViewUser.Columns[e.ColumnIndex].DataPropertyName == "UserRole")
            {
                if (e.Value != null)
                {
                    var roleValue = (byte)e.Value;

                    if (Enum.IsDefined(typeof(UserRole), roleValue))
                    {
                        e.Value = ((UserRole)roleValue).ToString();
                        e.FormattingApplied = true;
                    }
                }
            }
        }
    }
}
