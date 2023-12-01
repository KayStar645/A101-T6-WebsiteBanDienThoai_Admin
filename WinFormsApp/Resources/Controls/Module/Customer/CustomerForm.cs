using Controls.Module;
using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Resources.Controls.Module.Customer;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Customer
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerService _CustomerService;
        CustomerDto formData = new CustomerDto();

        public CustomerForm(CustomerDto formData)
        {

            InitializeComponent();

            _CustomerService = Program.container.GetInstance<ICustomerService>();

            this.formData = formData;

            LoadData();

            if (!Util.CheckPermission("Configuration.Update"))
            {
                Button_Save.Visible = false;
            }
        }

        public void LoadData()
        {
            Text_InternalCode.Text = formData.InternalCode;
            Text_Name.Text = formData.Name;
            Text_PhoneNumber.Text = formData.Phone;
            Text_Address.Text = formData.Phone;

            Label_Heading.Text = "Cập nhập khách hàng " + formData.Name;
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                formData.InternalCode = Text_InternalCode.Text;
                formData.Name = Text_Name.Text;
                formData.Address = Text_Address.Text;
                formData.Phone = Text_PhoneNumber.Text;

                if (formData.Id != 0)
                {
                    await _CustomerService.Update(formData);
                }

                CustomerControl._refreshButton.PerformClick();

                Close();
            }
            catch (Exception err)
            {
                Dialog_Notification.Show(err.Message);
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
