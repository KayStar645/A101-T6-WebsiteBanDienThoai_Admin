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

            _productService = Program.container.GetInstance<IProductService>();
            _refreshButton = Button_Refresh;
            _category = category;

            LoadProduct();
            Paginator();
        }

        private async void LoadProduct()
        {
            _result = await _productService.GetList("Name", _currPage, 15, Text_Search.Text, _category.Id);

            DataGridView_Listing.DataSource = _result.list;
        }

        private void Paginator()
        {
            //FlowLayoutPanel_Paginator.Controls.Clear();

            //for (int i = 1; i <= _result.pageNumber; i++)
            //{
            //    PaginatorButton button = new(i.ToString(), Button_Paginator_Click);

            //    FlowLayoutPanel_Paginator.Controls.Add(button);
            //}

            //if (_result.pageNumber > 0)
            //{
            //    FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = System.Drawing.Color.RoyalBlue;
            //    FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = System.Drawing.Color.White;
            //}
        }

        private async void Button_Paginator_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = System.Drawing.Color.White;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = System.Drawing.Color.Black;

            _currPage = int.Parse(button.Text);

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = System.Drawing.Color.RoyalBlue;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = System.Drawing.Color.White;
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
                //DialogResult dialogResult = Dialog_Confirm.Show();

                //if (dialogResult != DialogResult.Yes)
                //{
                //    return;
                //}

                //_productService.Delete(formData.Id);
                //Button_Refresh.PerformClick();
            }
        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            Timer_Debounce.Stop();
            Timer_Debounce.Start();
        }

        private async void Timer_Debounce_Tick(object sender, EventArgs e)
        {
            _currPage = 1;

            Paginator();

            LoadProduct();
        }
    }
}
