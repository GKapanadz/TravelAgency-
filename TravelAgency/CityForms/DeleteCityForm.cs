using TravelAgency.DTO;
using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgencyAPP.CityForms
{
    public partial class DeleteCityForm : Form
    {
        private readonly City _city;
        private readonly ICityService _service;
        public DeleteCityForm(City city)
        {
            InitializeComponent();
            _city = city;
            _service = CityServiceFactory.Create();

            lblMessage.Text = $"Are you sure you want to delete city: {_city.Name}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.DeleteCity(_city.CityID);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
