using Domain.DTOs;
using Services.Interfaces;
using SimpleInjector;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Distributor
{
    public partial class DistributorForm : Form
    {
        private readonly Container _container;
        private readonly IDistributorService _distributorService;
        DistributorDto formData = new DistributorDto();

        public DistributorForm(Container container)
        {
            _container = container;

            InitializeComponent();

            _distributorService = _container.GetInstance<IDistributorService>();

            OnInit();
        }

        public DistributorForm(Container container, DistributorDto formData)
        {
            _container = container;

            InitializeComponent();

            _distributorService = _container.GetInstance<IDistributorService>();

            this.formData = formData;

            LoadData();

            OnInit();
        }

        private void OnInit()
        {
            if (!Util.CheckPermission("Configuration.Update"))
            {
                Button_Save.Visible = false;
            }
        }

        public void LoadData()
        {
            Text_InternalCode.Text = formData.InternalCode;
            Text_Name.Text = formData.Name;
            Text_Address.Text = formData.Address;
            Text_Phone.Text = formData.Phone;

            Label_Heading.Text = "Cập nhập nhà cung cấp " + formData.Name;
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                formData.InternalCode = Text_InternalCode.Text;
                formData.Name = Text_Name.Text;
                formData.Address = Text_Address.Text;
                formData.Phone = Text_Phone.Text;

                if (formData.Id != 0)
                {
                    await _distributorService.Update(formData);
                }
                else
                {
                    await _distributorService.Create(formData);
                }

                DistributorControl._refreshButton.PerformClick();

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
