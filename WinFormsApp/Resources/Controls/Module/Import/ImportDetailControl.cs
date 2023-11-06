using Database.Interfaces;
using Domain.DTOs;
using Domain.ModelViews;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Import
{
    public partial class ImportDetailControl : UserControl
    {
        List<DetailImportDto> _products;
        ImportBillDto _import;
        IImportBillService _importBillService;

        public ImportDetailControl(int id)
        {
            InitializeComponent();

            _import = new ImportBillDto()
            {
                Id = id
            };

            OnInit();
        }

        public ImportDetailControl()
        {
            InitializeComponent();

            _import = new ImportBillDto();

            OnInit();
        }

        private async void OnInit()
        {
            _importBillService = Program.container.GetInstance<IImportBillService>();

            DateTime_ImportDate.Value = DateTime.Now;

            await GetProduct();
        }

        private async Task GetProduct()
        {
            if (_import.Id > 0)
            {
                var result = await _importBillService.GetDetail(_import.Id);

                _import = result;
                _products = result.Details!;
            }
            else
            {
                _import = new ImportBillDto();
                _products = new List<DetailImportDto>();
            }
        }

        private void Button_AddProduct_Click(object sender, EventArgs e)
        {
            if (_products.Count > 0)
            {
                Util.LoadForm(new ImportProductControl(OnSaveProduct, _products), true);

            }
            else
            {
                Util.LoadForm(new ImportProductControl(OnSaveProduct), true);
            }
        }

        private void OnSaveProduct(List<DetailImportDto> products)
        {
            _products = products;

            LoadProduct();
        }

        private void LoadProduct()
        {
            if (_import.Id > 0)
            {
            }
            else
            {
                DataGridView_Product.DataSource = _products;
            }

            foreach (DataGridViewRow item in DataGridView_Product.Rows)
            {
                item.Cells["Product_Select"].Value = true;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if(_import.Id > 0)
            {

            }
            else
            {

            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new ImportControl());
        }
    }
}
