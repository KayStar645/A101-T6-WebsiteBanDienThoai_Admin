using Controls.UI;
using Domain.DTOs;
using Domain.ModelViews;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Order
{
    public partial class OrderProductControl : Form
    {
        public delegate void OnSaveCallBack(List<DetailOrderDto> products);

        OnSaveCallBack _onSave;
        List<DetailOrderDto> _products;
        IProductService _productService;
        int _currPage = 1;
        (List<ProductVM> list, int totalCount, int pageNumber) _fetchData;

        public OrderProductControl(OnSaveCallBack onSave)
        {
            InitializeComponent();

            _productService = Program.container.GetInstance<IProductService>();
            _onSave = onSave;
            _products = new List<DetailOrderDto>();

            OnInit();
        }

        public OrderProductControl(OnSaveCallBack onSave, List<DetailOrderDto> products)
        {
            InitializeComponent();

            _productService = Program.container.GetInstance<IProductService>();

            _onSave = onSave;
            _products = products;

            OnInit();
        }

        private async void OnInit()
        {
            await LoadData();
            Paginator();

            if (_products.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow item in DataGridView_Product.Rows)
            {
                if (_products.FindIndex(t => t.ProductId == int.Parse(item.Cells["Id"].Value.ToString()!)) == -1)
                {
                    continue;
                }

                item.Cells["ProductSelect"].Value = "True";
            }
        }

        private async Task LoadData()
        {
            _fetchData = await _productService.GetList("Name", _currPage, 10, Text_Search.Text);

            foreach (var item in _fetchData.list)
            {
                item.Quantity = 0;
            }

            DataGridView_Product.DataSource = _fetchData.list;
        }

        private void Paginator()
        {
            Util.LoadControl(TableLayoutPanel_Paginator, new Paginator(_fetchData.pageNumber, _currPage, onClickPaginator), DockStyle.Right);
        }

        private async void onClickPaginator(int page)
        {
            _currPage = page;

            await LoadData();
            Paginator();
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

        private void Button_Save_Click(object sender, EventArgs e)
        {
            _onSave(_products);

            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = DataGridView_Product.CurrentRow.Cells;
            bool selected = bool.Parse(cells["ProductSelect"].FormattedValue.ToString()!);
            int id = int.Parse(cells["Id"].Value.ToString()!);

            if (e.ColumnIndex != 0)
            {
                return;
            }

            if (selected)
            {
                int index = _products.FindIndex(t => t.ProductId == id);

                cells["ProductSelect"].Value = "False";
                cells["Quantity"].Value = "0";

                if (index >= 0)
                {
                    _products.RemoveAt(index);
                }
            }
            else
            {
                cells["ProductSelect"].Value = "True";

                _products.Add(new DetailOrderDto()
                {
                    ProductId = id,
                    ProductInternalCode = cells["InternalCode"].Value.ToString(),
                    ProductName = cells["ProductName"].Value.ToString(),
                    CapacityName = cells["CapacityName"].Value.ToString(),
                    ColorName = cells["ColorName"].Value.ToString(),
                    Quantity = cells["Quantity"].Value == null ? 0 : int.Parse(cells["Quantity"].Value.ToString()!),
                    Price = long.Parse(cells["Price"].Value.ToString()!)
                });
            }
        }

        private void DataGridView_Product_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = DataGridView_Product.CurrentRow.Cells;
            bool selected = bool.Parse(cells["ProductSelect"].FormattedValue.ToString()!);
            int id = int.Parse(cells["Id"].Value.ToString()!);

            if (e.ColumnIndex == 0)
            {
                return;
            }

            int index = _products.FindIndex(t => t.ProductId == id);

            if (!selected)
            {
                return;
            }

            if (index == -1)
            {
                return;
            }

            _products[index].Quantity = int.Parse(cells["Quantity"].Value.ToString()!);
        }

        private void Btn_AddNewProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
