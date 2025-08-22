using System.Data;
using TravelAgency.DTO;
using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;
using TravelAgencyAPP.Interfaces;

namespace TravelAgencyAPP
{
    public partial class TourListForm : Form, IListForm
    {
        private readonly ITourService _tourService;
        private readonly Tour tour;
        public TourListForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = true;
            this.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.None;

            _tourService = TourServiceFactory.Create();
            LoadData(_tourService.GetAllTours());
        }

        public void Add()
        {
            AddTourForm form = new AddTourForm();
            form.ShowDialog();
        }

        public void Delete()
        {
            if (dataGridView.CurrentRow?.DataBoundItem is not Tour selectedTour)
            {
                FormHelper.ShowWarning(this, "Please select a tour to delete.");
                return;
            }

            DeleteTourForm deleteForm = new DeleteTourForm(selectedTour);
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                LoadData(_tourService.GetAllTours());
            }
        }

        public void Edit()
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.DataBoundItem is not Tour selectedTour)
            {
                FormHelper.ShowWarning(this, "Please select a tour to edit.");
                return;
            }

            EditTourForm editForm = new EditTourForm(selectedTour);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadData(_tourService.GetAllTours());
            }
        }

        public void LoadData(IEnumerable<object> data)
        {
            TourName.DataPropertyName = "Name";
            Duration.DataPropertyName = "Duration";
            TotalPrice.DataPropertyName = "TotalPrice";
            StartDate.DataPropertyName = "StartDate";
            EndDate.DataPropertyName = "EndDate";
            IsActive.DataPropertyName = "IsActive";

            dataGridView.DataSource = data.ToList();
        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            txtSearchBar.Clear();
        }

        private void txtSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                var searchText = txtSearchBar.Text.Trim().ToLower();
                var searchTextNoSpace = searchText.Replace(" ", "");

                var searchedItems = _tourService.GetToursByName("")
                    .Where(item =>
                    {
                        var name = item.Name.ToLower();
                        var nameNoSpace = name.Replace(" ", "");

                        return name.Contains(searchText) || nameNoSpace.Contains(searchTextNoSpace)
                            || item.Duration.ToString().Contains(searchText)
                            || item.TotalPrice.ToString().Contains(searchText)
                            || item.StartDate.ToShortDateString().ToLower().Contains(searchText)
                            || item.EndDate.ToShortDateString().ToLower().Contains(searchText);
                    });

                LoadData(searchedItems);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].DataPropertyName == "IsActive")
            {
                if(e.Value is bool Isactive)
                {
                    e.Value = Isactive ? "Active" : "Inactive";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
