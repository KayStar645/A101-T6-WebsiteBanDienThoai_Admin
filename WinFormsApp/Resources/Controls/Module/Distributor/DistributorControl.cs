using Guna.UI2.WinForms;
using Services;
using System.Data;
using WinFormsApp.Models;
using WinFormsApp.Repositories;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Distributor
{
    public partial class DistributorControl : UserControl
    {
        private DistributorRepository _distributorRepo = new DistributorRepository(StaticService.databaseAccess);

        public static Guna2Button refreshButton = new Guna2Button();

        public DistributorControl()
        {
            InitializeComponent();

            DataGridView_Listing.DataSource = _distributorRepo.Get(out int total);

            refreshButton = Button_Refresh;
        }

        public DistributorControl(DataTable distributorTable)
        {
            InitializeComponent();

            LoadData(distributorTable);

            refreshButton = Button_Refresh;
        }

        public void LoadData(DataTable distributorTable)
        {
            DataGridView_Listing.DataSource = distributorTable;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new DistributorForm());
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;
            DistributorModel formData = new()
            {
                Id = int.Parse(selected["Id"].FormattedValue.ToString()),
                InternalCode = selected["InternalCode"].FormattedValue.ToString(),
                Name = selected["_Name"].FormattedValue.ToString(),
                Address = selected["Address"].FormattedValue.ToString(),
                Phone = selected["Phone"].FormattedValue.ToString(),
            };

            if (e.ColumnIndex == 0)
            {
                Util.LoadForm(new DistributorForm(formData), true);
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if(dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _distributorRepo.Delete(formData.Id);
                Button_Refresh.PerformClick();
            }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            LoadData(_distributorRepo.Get(out int total));
        }
    }
}
