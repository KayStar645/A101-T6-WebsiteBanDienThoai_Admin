using Controls.UI;
using Domain.DTOs;
using Domain.ModelViews;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Promotion
{
    public partial class PromotionProductControl : Form
    {
        public delegate void OnSaveCallBack(List<ProductVM> products);

        OnSaveCallBack _onSave;
        List<ProductVM> _productIds;
        IProductService _productService;
        int _currPage = 1;
        (List<ProductVM> list, int totalCount, int pageNumber) _fetchData;

        public PromotionProductControl(OnSaveCallBack onSave)
        {
            InitializeComponent();

            _productService = Program.container.GetInstance<IProductService>();
            _onSave = onSave;
            _productIds = new List<ProductVM>();

            OnInit();
        }

        public PromotionProductControl(OnSaveCallBack onSave, List<ProductVM> products)
        {
            InitializeComponent();

            _productService = Program.container.GetInstance<IProductService>();

            _onSave = onSave;
            _productIds = products;

            OnInit();
        }

        private async void OnInit()
        {
            await LoadData();
            Paginator();

            if (_productIds == null || _productIds.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow item in DataGridView_Product.Rows)
            {
                if (_productIds.FindIndex(t => t.Id == int.Parse(item.Cells["Id"].Value.ToString()!)) == -1)
                {
                    continue;
                }

                item.Cells["Product_Select"].Value = "True";
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
            _onSave(_productIds);

            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = DataGridView_Product.CurrentRow.Cells;
            bool selected = bool.Parse(cells["Product_Select"].FormattedValue.ToString()!);
            int id = int.Parse(cells["Id"].Value.ToString()!);

            if (e.ColumnIndex != 0)
            {
                return;
            }

            if (selected)
            {
                int index = _productIds.FindIndex(t => t.Id == id);

                cells["Product_Select"].Value = "False";
                cells["Quantity"].Value = "0";

                if (index >= 0)
                {
                    _productIds.RemoveAt(index);
                }
            }
            else
            {
                cells["Product_Select"].Value = "True";

                _productIds.Add(new()
                {
                    Id = id,
                    InternalCode = cells["InternalCode"].Value.ToString(),
                    Name = cells["Product_Name"].Value.ToString(),
                    CapacityName = cells["CapacityName"]?.Value?.ToString(),
                    ColorName = cells["ColorName"].Value.ToString(),
                    Price = long.Parse(Util.DeleteCommas(cells["Price"].Value.ToString()!)),
                });
            }
        }
    }
}
