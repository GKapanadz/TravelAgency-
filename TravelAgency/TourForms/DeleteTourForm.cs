using TravelAgency.DTO;
using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgencyAPP
{
    public partial class DeleteTourForm : Form
    {
        private readonly Tour _tour;
        private readonly ITourService _tourService;
        public DeleteTourForm(Tour tour)
        {
            InitializeComponent();
            _tour = tour;
            _tourService = TourServiceFactory.Create();

            lblMessage.Text = $"Are you sure you want to delete the tour: {_tour.Name} ?";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _tourService.DeleteTour(_tour.TourID);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
