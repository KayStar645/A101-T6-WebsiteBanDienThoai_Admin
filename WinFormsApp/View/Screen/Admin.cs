﻿using Controls.Module;
using Services;

namespace WinFormsApp.View.Screen
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

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
    }
}
