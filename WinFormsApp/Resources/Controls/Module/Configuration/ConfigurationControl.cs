using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Configuration
{
    public partial class ConfigurationControl : UserControl
    {
        public static Guna2Button _refreahColorButton;
        public static Guna2Button _refreahCapacityButton;
        public static Guna2Button _refreahCategoryButton;

        private readonly IColorService _colorService;
        private readonly ICapacityService _capacityService;
        private readonly ICategoryService _categoryService;

        (List<ColorDto> list, int totalCount, int pageNumber) _colorResult;
        (List<CapacityDto> list, int totalCount, int pageNumber) _capacityResult;
        (List<CategoryDto> list, int totalCount, int pageNumber) _categoryResult;

        int _currPage = 1;

        public ConfigurationControl()
        {
            InitializeComponent();

            _colorService = Program.container.GetInstance<IColorService>();
            _capacityService = Program.container.GetInstance<ICapacityService>();
            _categoryService = Program.container.GetInstance<ICategoryService>();

            _refreahColorButton = Button_ColorRefresh;
            _refreahCapacityButton = Button_CapacityRefresh;
            _refreahCategoryButton = Button_CategoryRefresh;

            if (!Util.CheckPermission("Configuration.Create"))
            {
                TableLayoutPanel_Capacity.Controls.Remove(Button_CapacityCreate);
                TableLayoutPanel_Capacity.Controls.Remove(Button_ColorCreate);
                TableLayoutPanel_Capacity.Controls.Remove(Button_CategoryCreate);
            }

            if (!Util.CheckPermission("Configuration.Update"))
            {
                Button_CapacityEdit.Text = "Xem";
            }

            if (!Util.CheckPermission("Configuration.Delete"))
            {
                DataGridView_Capacity.Columns.RemoveAt(1);
            }

            LoadCapacity();
            LoadColor();
            LoadCategory();
        }

        private void Button_CapacityCreate_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new CapacityForm(), true);
        }

        private void Button_ColorCreate_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new ColorForm(), true);
        }

        private void Button_CategoryCreate_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new CategoryForm(), true);
        }

        private async void LoadCapacity()
        {
            _capacityResult = await _capacityService.GetList("Name", 1, 30, "");

            DataGridView_Capacity.DataSource = _capacityResult.list;


        }

        private async void LoadColor()
        {
            _colorResult = await _colorService.GetList("Name", 1, 30, "");

            DataGridView_Color.DataSource = _colorResult.list;
        }

        private async void LoadCategory()
        {
            _categoryResult = await _categoryService.GetList("Name", 1, 30, "");

            DataGridView_Category.DataSource = _categoryResult.list;
        }

        private void Button_CapacityRefresh_Click(object sender, EventArgs e)
        {
            LoadCapacity();
        }

        private void DataGridView_Capacity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Capacity.CurrentRow.Cells;
            CapacityDto formData = new()
            {
                Id = int.Parse(selected["Capacity_Id"].FormattedValue.ToString()),
                Name = selected["Capacity_Name"].FormattedValue.ToString(),
            };

            if (e.ColumnIndex == 0)
            {
                Util.LoadForm(new CapacityForm(formData), true);
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _capacityService.Delete(formData.Id);
                Button_CapacityRefresh.PerformClick();
            }
        }

        private void DataGridView_Color_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Color.CurrentRow.Cells;
            ColorDto formData = new()
            {
                Id = int.Parse(selected["Color_Id"].FormattedValue.ToString()),
                Name = selected["Color_Name"].FormattedValue.ToString(),
                InternalCode = selected["Color_InternalCode"].FormattedValue.ToString(),
            };

            if (e.ColumnIndex == 0)
            {
                Util.LoadForm(new ColorForm(formData), true);
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _colorService.Delete(formData.Id);
                Button_ColorRefresh.PerformClick();
            }
        }

        private void DataGridView_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCellCollection selected = DataGridView_Category.CurrentRow.Cells;
            CategoryDto formData = new()
            {
                Id = int.Parse(selected["Category_Id"].FormattedValue.ToString()),
                Name = selected["Category_Name"].FormattedValue.ToString(),
                InternalCode = selected["Category_InternalCode"].FormattedValue.ToString(),
            };

            if (e.ColumnIndex == 0)
            {
                Util.LoadForm(new CategoryForm(formData), true);
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _capacityService.Delete(formData.Id);
                Button_CapacityRefresh.PerformClick();
            }
        }

        private void Button_ColorRefresh_Click(object sender, EventArgs e)
        {
            LoadColor();
        }

        private void Button_CategoryRefresh_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }
    }
}
