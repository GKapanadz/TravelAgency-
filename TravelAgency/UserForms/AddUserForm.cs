using System.ComponentModel;
using TravelAgency.DTO;
using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgencyAPP
{
    public partial class AddUserForm : Form
    {
        private readonly IUserService _userService;
        public AddUserForm()
        {
            InitializeComponent();
            _userService = UserServiceFactory.Create();

            cbUserRole.DataSource = Enum.GetValues(typeof(UserRole));
            cbEmployeeId.DataSource = EnumHelper.GetEnumDescriptions<EmployeeEnum>();
            cbEmployeeId.DisplayMember = "Key";
            cbEmployeeId.ValueMember = "Value";

        }

        public enum UserRole : byte
        {
            Admin = 1,
            Operator = 2,
            Accountant = 3
        }

        public enum EmployeeEnum : int
        {
            [Description("John Doe")]
            JohnDoe = 1,

            [Description("Sarah Taylor")]
            SarahTaylor = 2,

            [Description("Michael Smith")]
            MichaelSmith = 3,

            [Description("Emily Johnson")]
            EmilyJohnson = 4,

            [Description("David Williams")]
            DavidWilliams = 5
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validations.ValidateName(txtName.Text, this))
                return;
            if (!Validations.ValidatePassword(txtPassword.Text, this))
                return;

            var selectedEmployee = (KeyValuePair<string, int>)cbEmployeeId.SelectedItem;

            User user = new()
            {
                UserID = (int)cbEmployeeId.SelectedValue,
                UserName = txtName.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                UserRole = (byte)(UserRole)cbUserRole.SelectedItem,
            };

            _userService.AddUser(user);
            FormHelper.ShowInfo(this, "User added successfully");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) 
        {
           this.Close();
        }
    }
    public class EnumHelper
    {
        public static List<KeyValuePair<string, int>> GetEnumDescriptions<T>() where T : Enum
        {
            var type = typeof(T);
            return Enum.GetValues(type)
                .Cast<T>()
                .Select(value =>
                {
                    var field = type.GetField(value.ToString());
                    var description = field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                           .Cast<DescriptionAttribute>()
                                           .FirstOrDefault()?.Description ?? value.ToString();
                    return new KeyValuePair<string, int>(description, Convert.ToInt32(value));
                })
                .ToList();
        }
    }

}
