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
            //    Phone = "0381921212",
            //};

            //bool isAdd = _distributorRepo.Add(distributor);
            //if (isAdd)
            //{
            //    MessageBox.Show("Thêm thành công!");
            //}
            //else
            //{
            //    MessageBox.Show("Thêm thất bại!");
            //}

            //DistributorModel distributor1 = new DistributorModel()
            //{
            //    Id = 13,
            //    InternalCode = Guid.NewGuid().ToString(),
            //    Name = "Đất trời",
            //    Address = "Bình Châu",
            //    Phone = "0999999999",
            //};

            //bool isUpdate = _distributorRepo.Update(distributor1);
            //if (isUpdate)
            //{
            //    MessageBox.Show("Cập nhật thành công!");
            //}
            //else
            //{
            //    MessageBox.Show("Cập nhật thất bại!");
            //}

            //_distributorRepo.Delete(15);

            int totalCout;
            DataTable dataTable = _distributorRepo.Get(out totalCout, null, "", null, "Id", 1, 5);

            dataGridView1.DataSource = dataTable;
            MessageBox.Show($"Có {totalCout} phần tử!");
        }
    }
}
