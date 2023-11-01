using Domain.DTOs;
using Services.Interfaces;

namespace WinFormsApp.Resources.Controls.Module.Configuration
{
    public partial class CategoryForm : Form
    {
        private readonly ICategoryService _categoryService;

        CategoryDto _formData = new CategoryDto();

        public CategoryForm()
        {
            InitializeComponent();

            _categoryService = Program.container.GetInstance<ICategoryService>();
        }

        public CategoryForm(CategoryDto formData)
        {
            InitializeComponent();

            _categoryService = Program.container.GetInstance<ICategoryService>();

            _formData = formData;

            LoadData();
        }

        public void LoadData()
        {
            ClearForm();

            Text_Name.Text = _formData.Name;
            Text_InternalCode.Text = _formData.InternalCode;
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

            if (_formData.Id != 0)
            {
                await _categoryService.Update(_formData);
            }
            else
            {
                await _categoryService.Create(_formData);
            }

            ConfigurationControl._refreahCategoryButotn.PerformClick();

            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
