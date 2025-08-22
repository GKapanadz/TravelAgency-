using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;
using TravelAgency.DTO;

namespace TravelAgencyAPP.CityForms
{
    public partial class AddCityForm : Form
    {
        private readonly ICityService _service;
        public AddCityForm()
        {
            _service = CityServiceFactory.Create();
            InitializeComponent();
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries));
        }

        public enum Countries : int
        {
            France = 1,
            Spain = 2,
            USA = 3,
            China = 4,
            UK = 5
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validations.ValidateName(txtBoxName.Text, this))
                return;

            City city = new()
            {
                Name = txtBoxName.Text,
                CountryID = (int)cmbCountry.SelectedValue
            };

            _service.AddCity(city);
            FormHelper.ShowInfo(this, "City added successfully");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
