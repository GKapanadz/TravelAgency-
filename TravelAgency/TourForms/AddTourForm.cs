using TravelAgency.DTO;
using TravelAgency.Services.Interfaces.Services;
using TravelAgency.Factories;

namespace TravelAgencyAPP
{
    public partial class AddTourForm : Form
    {
        private readonly ITourService _tourService;
        public AddTourForm()
        {
            _tourService = TourServiceFactory.Create();
            InitializeComponent();
        }

        private void txtTotalPrice_Enter(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text == "0")
            {
                txtTotalPrice.Clear();
            }
        }

        private void txtTotalPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotalPrice.Text))
            {
                txtTotalPrice.Text = "0";
            }
        }

        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;

            if (char.IsControl(chr))
            {
                return;
            }
            if (char.IsDigit(chr))
            {
                return;
            }
            if (chr == '.' && !txtTotalPrice.Text.Contains('.'))
            {
                return;
            }

            e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validations.ValidateName(txtName.Text, this))
                return;

            if (!Validations.ValidateDates(dtpStartDate.Value, dtpEndDate.Value, this))
                return;
            if (!Validations.ValidateTotalPrice(txtTotalPrice.Text, this, out double totalPrice))
                return;

            Tour tour = new()
            {
                Name = txtName.Text,
                Duration = (int)nudDuration.Value,
                TotalPrice = totalPrice,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value
            };

            _tourService.AddTour(tour);
            FormHelper.ShowInfo(this, "Tour added successfully");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
