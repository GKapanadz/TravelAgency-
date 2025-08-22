using System.Data;
using TravelAgency.DTO;
using TravelAgency.Factories;
using TravelAgency.Services.Interfaces.Services;
using TravelAgencyAPP.Interfaces;

namespace TravelAgencyAPP.CityForms
{
    public partial class CityListForm : Form, IListForm
    {

        private readonly ICityService _cityService;
        private readonly City _city;
        public CityListForm()
        {
            InitializeComponent();
            CityDataGridView.AutoGenerateColumns = true;
         
            _cityService = CityServiceFactory.Create();
            LoadData(_cityService.GetAllCities());
        }

        public void Add()
        {
            AddCityForm form = new AddCityForm();
            form.ShowDialog();
        }

        public void Delete()
        {
            if (CityDataGridView.CurrentRow?.DataBoundItem is not City selectedCity)
            {
                FormHelper.ShowWarning(this, "Please select a tour to delete.");
                return;
            }

            DeleteCityForm deleteForm = new DeleteCityForm(selectedCity);
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                LoadData(_cityService.GetAllCities());
            }
        }

        public void Edit()
        {
            if(CityDataGridView.CurrentRow == null || CityDataGridView.CurrentRow.DataBoundItem is not City selectedCity)
            {
                FormHelper.ShowWarning(this, "Please select city to edit");
                return;
            }

            EditCityFrom form = new EditCityFrom(selectedCity);
            if(form.ShowDialog() == DialogResult.OK)
            {
                LoadData(_cityService.GetAllCities());
            }
        }

        public void LoadData(IEnumerable<object> data)
        {
            CityDataGridView.DataSource = data.ToList();
        }

        private void txtCitiesSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                var searchText = txtSearchBar.Text.Trim().ToLower();
                var searchTextNoSpace = searchText.Replace(" ", "");

                var searchedItems = _cityService.GetCityByName("")
                    .Where(item =>
                    {
                        var name = item.Name.ToLower();
                        var nameNoSpace = name.Replace(" ", "");

                        return name.Contains(searchText) || nameNoSpace.Contains(searchTextNoSpace)
                            || item.Name.ToString().Contains(searchText)
                            || item.CountryID.ToString().Contains(searchText);
                    });

                LoadData(searchedItems);
            }
        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            txtSearchBar.Clear();
        }
    }
}
