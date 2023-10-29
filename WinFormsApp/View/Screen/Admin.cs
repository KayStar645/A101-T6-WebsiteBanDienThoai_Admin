using AutoMapper;
using Database.Interfaces;
using Database.Repositories;
using Services.Interfaces;
using Services.Profiles;
using Services.Services;
using WinFormsApp.Resources.Controls.Module;
using WinFormsApp.Resources.Controls.Module.Distributor;
using WinFormsApp.Services;

namespace WinFormsApp.View.Screen
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            OnInit();
        }

        private void OnInit()
        {

            Util.LoadControl(Panel_Body, new DistributorControl(Program.container));
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
            Util.LoadControl(Panel_Body, new DistributorControl(Program.container));
        }

        private void Btn_Promotion_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách chương trình khuyến mãi";
        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách đơn hàng";
        }

        private void Btn_CouponEnter_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách hóa đơn nhập";
        }

        private void Btn_Phone_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách điện thoại";
        }

        private void Btn_EarPhone_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách tai nghe";
        }

        private void Btn_Charger_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách củ sạc";
        }

        private void Btn_PhoneCase_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách ớp lưng";
        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách nhân viên";
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách khách hàng";
        }

        private void Btn_PriceHistory_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách lịch sử giá";
        }

        private void Btn_Configuration_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Cấu hình chung";

            Util.LoadControl(Panel_Body, new ConfigurationControl());
        }
    }
}
