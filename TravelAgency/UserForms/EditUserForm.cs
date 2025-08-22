using TravelAgency.DTO;
using TravelAgency.Services.Interfaces.Services;
using TravelAgency.Factories;

namespace TravelAgencyAPP
{
    public partial class EditUserForm : Form
    {
        private readonly IUserService _userService;
        private readonly User _user;
        public EditUserForm(User user)
        {
            _userService = UserServiceFactory.Create();
            _user = user;
            InitializeComponent();
            cbUserRole.DataSource = Enum.GetValues(typeof(UserRole));
            PopulateFields();
        }

        public enum UserRole : byte
        {
            Admin = 1,
            Operator = 2,
            Accountant = 3
        }

        public void PopulateFields()
        {
            txtBoxName.Text = _user.UserName;
            cbUserRole.SelectedItem = _user.UserRole;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!Validations.ValidateName(txtBoxName.Text, this, txtBoxName))
                return;

            var confirmResult = MessageBox.Show(
               "Are you sure you want to edit this user ?",
               "Confirm Edit",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            _user.UserName = txtBoxName.Text.Trim();
            _user.UserRole = (byte)(UserRole)cbUserRole.SelectedItem;
            if (!string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                _user.Password = txtBoxPassword.Text;
            }
            else
            {
                _user.Password = null;
            }

            _userService.EditUser(_user);
            FormHelper.ShowInfo(this, "User has been successfully updated.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
