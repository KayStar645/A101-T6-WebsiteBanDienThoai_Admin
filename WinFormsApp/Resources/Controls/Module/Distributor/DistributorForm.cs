using Domain.DTOs;
using Services.Interfaces;
using SimpleInjector;

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
        }

        public DistributorForm(Container container, DistributorDto formData)
        {
            _container = container;

            InitializeComponent();

            _distributorService = _container.GetInstance<IDistributorService>();

            this.formData = formData;

            this.LoadData();
        }

        public void LoadData()
        {
            ClearForm();

            Text_InternalCode.Text = formData.InternalCode;
            Text_Name.Text = formData.Name;
            Text_Address.Text = formData.Address;
            Text_Phone.Text = formData.Phone;
        }

        private void ClearForm()
        {
            Text_InternalCode.Clear();
            Text_Name.Clear();
            Text_Address.Clear();
            Text_Phone.Clear();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            formData.InternalCode = Text_InternalCode.Text;
            formData.Name = Text_Name.Text;
            formData.Address = Text_Address.Text;
            formData.Phone = Text_Phone.Text;

            if (formData.Id != 0)
            {
                _distributorService.Update(formData);
            }
            else
            {
                _distributorService.Create(formData);
            }

            DistributorControl._refreshButton.PerformClick();

            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
