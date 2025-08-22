using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgencyAPP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

#if(DEBUG)
            txt_Username.Text = "admin";
            txt_Password.Text = "admin123";
#endif

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                this.ShowInfo("please enter username and password");
                return false;
            }

            return true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                IUserService userService = UserServiceFactory.Create();
                LocalStorage.UserId = userService.LoginUser(txt_Username.Text, txt_Password.Text);
                LocalStorage.Username = txt_Username.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
