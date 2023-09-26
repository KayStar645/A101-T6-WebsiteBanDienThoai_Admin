using System.Data;
using WinFormsApp.Models;
using WinFormsApp.Repositories;
using WinFormsApp.Services;

namespace WinFormsApp.View.Test
{
    public partial class frmTest : Form
    {
        private DistributorRepository _distributorRepo = new DistributorRepository(StaticService.databaseAccess);

        public frmTest()
        {
            InitializeComponent();
            testData();



        }

        private void testData()
        {

            //DistributorModel distributor = new DistributorModel()
            //{
            //    InternalCode = Guid.NewGuid().ToString(),
            //    Name = "Phương Nam",
            //    Address = "Tân Phú",
            //    Phone = "0381921212"
            //};

            //bool isAdd = _distributorRepo.Add(distributor);
            //if(isAdd )
            //{
            //    MessageBox.Show("Thêm thành công!");
            //}
            //else
            //{
            //    MessageBox.Show("Thêm thất bại!");
            //}    

            DataTable dataTable = _distributorRepo.Get(null, "", 13);

            dataGridView1.DataSource = dataTable;
        }
    }
}
