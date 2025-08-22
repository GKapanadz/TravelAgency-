using TravelAgency.DTO;
using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgencyAPP.CityForms
{
    public partial class EditCityFrom : Form
    {
        private readonly City _city;
        private readonly ICityService _service;

        public EditCityFrom(City city)
        {
            _service = CityServiceFactory.Create();
            _city = city;
            InitializeComponent();
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries));
            PopulateFields();
        }

        public enum Countries : int
        {
            France = 1,
            Spain = 2,
            USA = 3,
            China = 4,
            UK = 5
        }

        private void PopulateFields()
        {
            txtBoxName.Text = _city.Name;
            cmbCountry.SelectedItem = (Countries)_city.CountryID;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Validations.ValidateName(txtBoxName.Text, this))
                return;

            var confirmResult = MessageBox.Show(
                "Are you shure you want edit this city ? ",
                "Confirm Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
                return;

            _city.Name = txtBoxName.Text;
            _city.CountryID = (int)cmbCountry.SelectedValue;

            _service.EditCity(_city);
            FormHelper.ShowInfo(this, "City has been successfully updated");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
