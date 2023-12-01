using Controls.UI;
using Domain.DTOs;
using Domain.ModelViews;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Product
{
    public partial class ProductControl : UserControl
    {
        public static Guna2Button _refreshButton = new();

        IProductService _productService;
        CategoryDto _category;
        (List<ProductVM> list, int totalCount, int pageNumber) _result;
        int _currPage = 1;

        public ProductControl(CategoryDto category)
        {
            InitializeComponent();

            _category = category;

            OnInit();
        }

        private async void OnInit()
        {
            _productService = Program.container.GetInstance<IProductService>();
            _refreshButton = Button_Refresh;

            if (!Util.CheckPermission("Product.Create"))
            {
                Button_Create.Visible = false;
            }

            if (!Util.CheckPermission("Product.Update"))
            {
                Button_Edit.Text = "Xem";
            }

            if (!Util.CheckPermission("Product.Delete"))
            {
                DataGridView_Listing.Columns.RemoveAt(1);
            }

            await LoadData();
            Paginator();
        }

        private async Task LoadData()
        {
            _result = await _productService.GetList("Name", _currPage, 15, Text_Search.Text, _category.Id);

            DataGridView_Listing.DataSource = _result.list;

            DataGridView_Listing.Columns["Quantity"].DisplayIndex = 12;
        }

        private void Paginator()
        {
            Util.LoadControl(TableLayoutPanel_Paginator, new Paginator(_result.pageNumber, _currPage, onClickPaginator), DockStyle.Right);
        }

        private async void onClickPaginator(int page)
        {
            _currPage = page;

            await LoadData();
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new ProductDetailControl(_category));
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;

            ProductVM formData = _result.list.Find(t => t.Id == int.Parse(selected["Id"].Value!.ToString()!));

            if (formData == null)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                Util.LoadControl(this, new ProductDetailControl(formData.Id));
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _productService.Delete(formData.Id);
                Button_Refresh.PerformClick();
            }
        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            Timer_Debounce.Start();
        }

        private async void Timer_Debounce_Tick(object sender, EventArgs e)
        {
            _currPage = 1;

            await LoadData();

            Paginator();

            Timer_Debounce.Stop();
        }
    }
}
