using Domain.DTOs;
using Services.Interfaces;
using SimpleInjector;

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
        }

        private void ClearForm()
        {
            Text_Name.Clear();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            _formData.Name = Text_Name.Text;

            if (_formData.Id != 0)
            {
                _distributorService.Update(_formData);
            }
            else
            {
                _distributorService.Create(_formData);
            }

            ConfigurationControl._refreahCapacityButotn.PerformClick();

            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
