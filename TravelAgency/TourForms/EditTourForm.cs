using TravelAgency.Services.Interfaces.Services;
using TravelAgency.DTO;
using TravelAgency.Factories;

namespace TravelAgencyAPP
{
    public partial class EditTourForm : Form
    {
        private readonly Tour _tour;

        private readonly ITourService _tourService;
        public EditTourForm(Tour tour)
        {
            _tour = tour;
            _tourService = TourServiceFactory.Create();
            InitializeComponent();
            PolpulateFields();

        }

        private void PolpulateFields()
        {
            txtBoxName.Text = _tour.Name;
            nudDuration.Value = _tour.Duration;
            txtTotalPrice.Text = _tour.TotalPrice.ToString("F2");
            dtpStartDate.Value = _tour.StartDate;
            dtpEndDate.Value = _tour.EndDate;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!Validations.ValidateName(txtBoxName.Text, this, txtBoxName))
                return;
            if (!Validations.ValidateDates(dtpStartDate.Value, dtpEndDate.Value, this))
                return;
            if (!Validations.ValidateTotalPrice(txtTotalPrice.Text, this, out double totalPrice))
                return;
             var confirmResult = MessageBox.Show(
               "Are you sure you want to edit this tour?",
               "Confirm Edit",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            _tour.Name = txtBoxName.Text.Trim();
            _tour.Duration = (int)nudDuration.Value;
            _tour.TotalPrice = totalPrice;
            _tour.StartDate = dtpStartDate.Value;
            _tour.EndDate = dtpEndDate.Value;

            _tourService.EditTour(_tour);
            FormHelper.ShowInfo(this, "Tour has been successfully updated.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
