using TravelAgency.DTO;
using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgencyAPP
{
    public partial class DeleteUserForm : Form
    {
        private readonly User _user;
        private readonly IUserService _userService;
        public DeleteUserForm(User user)
        {
            InitializeComponent();
            _user = user;
            _userService = UserServiceFactory.Create();

            lblMessage.Text = $"Are you sure you want to delete the user: {_user.UserName} ?";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _userService.DeleteUser(_user.UserID);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
