using System.Data;
using WinFormsApp.Common;
using WinFormsApp.Models;
using WinFormsApp.Repositories;

namespace WinFormsApp.View.Test
{
    public partial class frmTest : Form
    {
        private DistributorRepository _distributorRepo = new DistributorRepository(StaticCommon.DatabaseAccess);
        private EmployeeRepository _employeeRepo = new EmployeeRepository(StaticCommon.DatabaseAccess);
        private CustomerRepository _customerRepo = new CustomerRepository(StaticCommon.DatabaseAccess);

        public frmTest()
        {
            InitializeComponent();
            //testData();
            //testDataEmployee();
            testDataCustomer();
        }


        private void testDataCustomer()
        {

            CustomerModel customer = new CustomerModel()
            {
                InternalCode = Guid.NewGuid().ToString(),
                Phone = "0215487598",
                Name = "Nguyễn Văn A",
                Address = "140 Lê Trọng Tấn",
            };

            bool isAdd = _customerRepo.Add(customer);
            if (isAdd)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

            CustomerModel customer1 = new CustomerModel()
            {
                Id = 1,
                InternalCode = Guid.NewGuid().ToString(),
                Phone = "0215488558",
                Name = "Nguyễn Văn C",
                Address = "170 Lê Trọng Tấn",
            };

            bool isUpdate = _customerRepo.Update(customer1);
            if (isUpdate)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }

            _customerRepo.Delete(1);

            DataTable dataTable = _distributorRepo.Get();


            dataGridView1.DataSource = dataTable;
        }


        private void testDataEmployee()
        {

            EmployeeModel employee = new EmployeeModel()
            {
                InternalCode = Guid.NewGuid().ToString(),
                Name = "Phương Nam",
                Sex = "Nam",
                Birthday = new DateTime(2002, 3, 6),
                Phone = "0381921212",
            };

            bool isAdd = _employeeRepo.Add(employee);
            if (isAdd)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

            EmployeeModel employee1 = new EmployeeModel()
            {
                Id = 1,
                InternalCode = Guid.NewGuid().ToString(),
                Name = "phatstran",
                Sex = "Nam",
                Phone = "0123548796",
            };

            bool isUpdate = _employeeRepo.Update(employee1);
            if (isUpdate)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }

            _employeeRepo.Delete(1);

            DataTable dataTable = _distributorRepo.Get();


            dataGridView1.DataSource = dataTable;
        }


        private void testData()
        {

            DistributorModel distributor = new DistributorModel()
            {
                InternalCode = Guid.NewGuid().ToString(),
                Name = "Phương Nam",
                Address = "Tân Phú",
                Phone = "0381921212",
            };

            bool isAdd = _distributorRepo.Add(distributor);
            if (isAdd)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

            DistributorModel distributor1 = new DistributorModel()
            {
                Id = 1,
                InternalCode = Guid.NewGuid().ToString(),
                Name = "Đất trời",
                Address = "Bình Châu",
                Phone = "0999999999",
            };

            bool isUpdate = _distributorRepo.Update(distributor1);
            if (isUpdate)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }

            _distributorRepo.Delete(2);

            DataTable dataTable = _distributorRepo.Get();


            dataGridView1.DataSource = dataTable;
        }
    }
}
