using Domain.DTOs;
using Services.Interfaces;

namespace WinFormsApp.Resources.Controls.Module.Configuration
{
    public partial class CapacityForm : Form
    {
        private readonly ICapacityService _distributorService;

        CapacityDto _formData = new CapacityDto();

        public CapacityForm()
        {
            InitializeComponent();

            _distributorService = Program.container.GetInstance<ICapacityService>();
        }

        public CapacityForm(CapacityDto formData)
        {
            InitializeComponent();

            _distributorService = Program.container.GetInstance<ICapacityService>();

            _formData = formData;

            LoadData();
        }

        public void LoadData()
        {
            ClearForm();

            Text_Name.Text = _formData.Name;
            Label_Heading.Text = "Cập nhập dung lượng " + _formData.Name;
        }

        private void ClearForm()
        {
            Text_Name.Clear();
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _formData.Name = Text_Name.Text;

            try
            {
                if (_formData.Id != 0)
                {
                    await _distributorService.Update(_formData);
                }
                else
                {
                    await _distributorService.Create(_formData);
                }

                ConfigurationControl._refreahCapacityButton.PerformClick();

                Close();
            }
            catch (Exception ex)
            {
                Dialog_Notification.Show(ex.Message);
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
