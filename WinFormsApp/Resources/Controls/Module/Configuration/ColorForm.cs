using Domain.DTOs;
using Services.Interfaces;

namespace WinFormsApp.Resources.Controls.Module.Configuration
{
    public partial class ColorForm : Form
    {
        private readonly IColorService _colorService;

        ColorDto _formData = new ColorDto();

        public ColorForm()
        {
            InitializeComponent();

            _colorService = Program.container.GetInstance<IColorService>();
        }

        public ColorForm(ColorDto formData)
        {
            InitializeComponent();

            _colorService = Program.container.GetInstance<IColorService>();

            _formData = formData;

            LoadData();
        }

        public void LoadData()
        {
            ClearForm();

            Text_Name.Text = _formData.Name;
            Text_InternalCode.Text = _formData.InternalCode;

            Label_Heading.Text = "Cập nhập màu " + _formData.Name;
        }

        private void ClearForm()
        {
            Text_Name.Clear();
            Text_InternalCode.Clear();
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _formData.Name = Text_Name.Text;
            _formData.InternalCode = Text_InternalCode.Text;

            try
            {
                if (_formData.Id != 0)
                {
                    await _colorService.Update(_formData);
                }
                else
                {
                    await _colorService.Create(_formData);
                }

                ConfigurationControl._refreahColorButton.PerformClick();

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
