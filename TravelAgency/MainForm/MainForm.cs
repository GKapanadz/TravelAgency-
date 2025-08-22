using TravelAgencyAPP.CityForms;
using TravelAgencyAPP.Interfaces;

namespace TravelAgencyAPP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
         => ShowListForm<TourListForm>();

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
         => ShowListForm<UserListForm>();

        private void searchCitiesToolStripMenuItem_Click_1(object sender, EventArgs e)
         => ShowListForm<CityListForm>();


        private void addTourStripMenuItem_Click(object sender, EventArgs e)
         => (ActiveMdiChild as IListForm)?.Add();

        private void editTourToolStripMenuItem_Click(object sender, EventArgs e)
         => (ActiveMdiChild as IListForm)?.Edit();

        private void deleteTourToolStripMenuItem_Click(object sender, EventArgs e)
        => (ActiveMdiChild as IListForm)?.Delete();

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        => (ActiveMdiChild as IListForm)?.Add();

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        => (ActiveMdiChild as IListForm)?.Edit();

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        => (ActiveMdiChild as IListForm)?.Delete();

        private void addCityToolStripMenuItem_Click(object sender, EventArgs e)
        => (ActiveMdiChild as IListForm)?.Add();

        private void editCityToolStripMenuItem_Click(object sender, EventArgs e)
        => (ActiveMdiChild as IListForm)?.Edit();

        private void deleteCityToolStripMenuItem_Click(object sender, EventArgs e)
        => (ActiveMdiChild as IListForm)?.Delete();

        private void ShowListForm<T>() where T : Form, new()
        {
            var openForm = MdiChildren.FirstOrDefault(f => f is T);

            if (openForm != null)
            {
                openForm.BringToFront();
            }
            else
            {
                var form = new T
                {
                    MdiParent = this
                };
                form.Show();
            }
        }

    }
}
