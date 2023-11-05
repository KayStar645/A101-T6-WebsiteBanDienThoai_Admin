﻿using Controls.UI;
using Domain.Entities;
using Domain.ModelViews;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Import
{
    public partial class ImportProductControl : Form
    {
        public delegate void OnSaveCallBack(List<ProductVM> products);

        OnSaveCallBack _onSave;
        List<ProductVM> _products;
        IProductService _productService;
        int _currPage = 1;
        (List<ProductVM> list, int totalCount, int pageNumber) _fetchData;

        public ImportProductControl(OnSaveCallBack onSave)
        {
            InitializeComponent();

            _productService = Program.container.GetInstance<IProductService>();
            _onSave = onSave;
            _products = new List<ProductVM>();

            OnInit();
        }

        public ImportProductControl(OnSaveCallBack onSave, List<ProductVM> products)
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

            if(_products.Count > 0)
            {
                foreach (DataGridViewRow item in DataGridView_Product.Rows)
                {
                    if(_products.FindIndex(t => t.Id == int.Parse(item.Cells["Id"].Value.ToString()!)) == -1)
                    {
                        continue;
                    }

                    item.Cells["Product_Select"].Value = "True";
                }
            }

            Paginator();
        }

        private async Task LoadData()
        {
            _fetchData = await _productService.GetList("Name", _currPage, 15, Text_Search.Text);

            DataGridView_Product.DataSource = _fetchData.list;
        }

        private void Paginator()
        {
            Util.AddControl(TableLayoutPanel_Pagination, new Paginator(_fetchData.pageNumber, _currPage, onClickPaginator), DockStyle.Right);
        }

        private async void onClickPaginator(int page)
        {
            _currPage = page;

            LoadData();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {

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

        private void Timer_Debounce_Tick(object sender, EventArgs e)
        {

        }

        private void DataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = DataGridView_Product.CurrentRow.Cells;
            bool selected = bool.Parse(cells["Product_Select"].FormattedValue.ToString()!);
            int id = int.Parse(cells["Id"].Value.ToString()!);

            if (selected)
            {
                int index = _products.FindIndex(t => t.Id == id);

                cells["Product_Select"].Value = "False";

                if (index >= 0)
                {
                    _products.RemoveAt(index);
                }
            }
            else
            {
                cells["Product_Select"].Value = "True";

                _products.Add(new ProductVM()
                {
                    Id = id,
                    InternalCode = cells["InternalCode"].Value.ToString(),
                    Name = cells["Product_Name"].Value.ToString(),
                    CapacityId = int.Parse(cells["CapacityId"].Value.ToString()!),
                    CapacityName = cells["CapacityName"].Value.ToString(),
                    CategoryId = int.Parse(cells["CategoryId"].Value.ToString()!),
                    ColorId = int.Parse(cells["ColorId"].Value.ToString()!),
                    ColorName = cells["ColorName"].Value.ToString(),
                    Quantity = int.Parse(cells["Quantity"].Value.ToString()!),
                    Price = long.Parse(cells["Price"].Value.ToString()!)
                });
            }
        }
    }
}
