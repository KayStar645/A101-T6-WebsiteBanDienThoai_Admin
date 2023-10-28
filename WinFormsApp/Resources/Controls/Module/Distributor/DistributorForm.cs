using Domain.DTOs;
using Services.Services;

namespace WinFormsApp.Resources.Controls.Module.Distributor
{
    public partial class DistributorForm : Form
    { 
        DistributorDto formData = new DistributorDto();

        private readonly DistributorService _distributorService;

        public DistributorForm()
        {
            InitializeComponent();
        }

        public DistributorForm(DistributorDto formData)
        {
            InitializeComponent();

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
            if (formData.Id != 0)
            {
                _distributorService.Update(formData);
            }
            else
            {
                _distributorService.Create(formData);
            }

            DistributorControl.refreshButton.PerformClick();

            Close();
        }

        private void Text_InternalCode_TextChanged(object sender, EventArgs e)
        {
            formData.InternalCode = Text_InternalCode.Text;
        }

        private void Text_Name_TextChanged(object sender, EventArgs e)
        {
            formData.Name = Text_Name.Text;
        }

        private void Text_Address_TextChanged(object sender, EventArgs e)
        {
            formData.Address = Text_Address.Text;
        }

        private void Text_Phone_TextChanged(object sender, EventArgs e)
        {
            formData.Phone = Text_Phone.Text;
        }
    }
}
