using Services;
using System.Data;

namespace WinFormsApp.Resources.Controls.Module.Distributor
{
    public partial class DistributorControl : UserControl
    {
        private DataTable distributorTable;
        private DistributorForm distributorForm;

        public DataTable DistributorTable { get => distributorTable; set => distributorTable = value; }
        public DistributorForm DistributorForm { get => distributorForm; set => distributorForm = value; }

        public DistributorControl()
        {
            InitializeComponent();
        }

        public DistributorControl(DataTable distributorTable)
        {
            InitializeComponent();

            this.distributorTable = distributorTable;

            distributorForm = new DistributorForm();

            LoadData();
        }


        public void LoadData()
        {
            DataGridView_Listing.DataSource = distributorTable;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadForm(distributorForm);
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                DataGridViewRow selected = DataGridView_Listing.SelectedRows[0];
            }
        }
    }
}
