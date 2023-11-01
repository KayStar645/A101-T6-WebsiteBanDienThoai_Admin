using Guna.UI2.WinForms;
using WinFormsApp.Resources.Controls.Module.Configuration;
using WinFormsApp.Resources.Controls.Module.Distributor;
using WinFormsApp.Resources.Controls.Module.Employee;
using WinFormsApp.Resources.Controls.Module.Product;
using WinFormsApp.Services;

namespace WinFormsApp.View.Screen
{
    public partial class Admin : Form
    {
        string _currPanel;

        public Admin()
        {
            InitializeComponent();

            OnInit();
        }

        private void OnInit()
        {
            Util.LoadControl(Panel_Body, new DistributorControl());
        }

        private void LoadMenu()
        {
            var masterDataControls = Panel_MaterData.Controls;
            var productControls = Panel_Product.Controls;
            var systemControls = Panel_System.Controls;

            if (_currPanel != "panel_masterData")
            {
                for (int i = 1; i < masterDataControls.Count; i++)
                {
                    Guna2Button btn = (Guna2Button)masterDataControls[i];

                    btn.Checked = false;
                }
            }

            if (_currPanel != "panel_product")
            {
                for (int i = 1; i < productControls.Count; i++)
                {
                    Guna2Button btn = (Guna2Button)productControls[i];

                    btn.Checked = false;
                }
            }

            if (_currPanel != "panel_system")
            {
                for (int i = 1; i < systemControls.Count; i++)
                {
                    Guna2Button btn = (Guna2Button)systemControls[i];

                    btn.Checked = false;
                }
            }
        }

        private void Btn_MasterData_Click(object sender, EventArgs e)
        {
            Util.Scroll(Btn_MasterData.Checked, Panel_MaterData);
        }

        private void Btn_Product_Click(object sender, EventArgs e)
        {
            Util.Scroll(Btn_Product.Checked, Panel_Product);
        }

        private void Btn_System_Click(object sender, EventArgs e)
        {
            Util.Scroll(Btn_System.Checked, Panel_System);
        }

        private void Btn_Distributor_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách nhà cung cấp";
            Util.LoadControl(Panel_Body, new DistributorControl());

            _currPanel = Btn_Distributor.Tag.ToString();
            LoadMenu();
        }

        private void Btn_Promotion_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách chương trình khuyến mãi";

            _currPanel = Btn_Promotion.Tag.ToString();
            LoadMenu();
        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách đơn hàng";

            _currPanel = Btn_Order.Tag.ToString();
            LoadMenu();
        }

        private void Btn_CouponEnter_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách hóa đơn nhập";

            _currPanel = Btn_CouponEnter.Tag.ToString();
            LoadMenu();
        }

        private void Btn_Phone_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách điện thoại";
            Util.LoadControl(Panel_Body, new ProductControl());

            _currPanel = Btn_Phone.Tag.ToString();
            LoadMenu();
        }

        private void Btn_EarPhone_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách tai nghe";

            _currPanel = Btn_EarPhone.Tag.ToString();
            LoadMenu();
        }

        private void Btn_Charger_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách củ sạc";

            _currPanel = Btn_Charger.Tag.ToString();
            LoadMenu();
        }

        private void Btn_PhoneCase_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách ớp lưng";

            _currPanel = Btn_PhoneCase.Tag.ToString();
            LoadMenu();
        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách nhân viên";
            Util.LoadControl(Panel_Body, new EmployeeControl());

            _currPanel = Btn_Employee.Tag.ToString();
            LoadMenu();
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách khách hàng";

            _currPanel = Btn_Customer.Tag.ToString();
            LoadMenu();
        }

        private void Btn_Configuration_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Cấu hình chung";
            Util.LoadControl(Panel_Body, new ConfigurationControl());

            _currPanel = Btn_Configuration.Tag.ToString();
            LoadMenu();
        }
    }
}
