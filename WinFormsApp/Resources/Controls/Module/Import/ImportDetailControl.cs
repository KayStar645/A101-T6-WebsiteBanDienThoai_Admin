using Database.Interfaces;
using Domain.DTOs;
using Domain.ModelViews;
using Services.Interfaces;
using System.ComponentModel;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Import
{
    public partial class ImportDetailControl : UserControl
    {
        ImportBillDto _import;
        IImportBillService _importBillService;
        IDistributorService _distributorService;

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

            _import.Id = 0;

            OnInit();
        }

        private async void OnInit()
        {
            _importBillService = Program.container.GetInstance<IImportBillService>();
            _distributorService = Program.container.GetInstance<IDistributorService>();

            DateTime_ImportDate.Value = DateTime.Now;

            await LoadData();
        }

        private async void LoadDistributor()
        {
            var result = await _distributorService.GetList("Name", 1, 30);

            ComboBox_Distributor.DataSource = result.list;
            ComboBox_Distributor.DisplayMember = "Name";
            ComboBox_Distributor.ValueMember = "Id";
        }

        private async Task LoadData()
        {
            if (_import.Id > 0)
            {
                var result = await _importBillService.GetDetail(_import.Id);

                _import = result;

                LoadProduct();
            }
            else
            {
                _import = new ImportBillDto();
                _import.Details = new List<DetailImportDto>();
                LoadDistributor();
            }
        }

        private void Button_AddProduct_Click(object sender, EventArgs e)
        {
            if (_import.Details.Count > 0)
            {
                Util.LoadForm(new ImportProductControl(OnSaveProduct, _import.Details), true);

            }
            else
            {
                Util.LoadForm(new ImportProductControl(OnSaveProduct), true);
            }
        }

        private void OnSaveProduct(List<DetailImportDto> products)
        {
            _import.Details = products;

            LoadProduct();
        }

        private void LoadProduct()
        {
            DataGridView_Product.Rows.Clear();

            foreach (DetailImportDto item in _import.Details)
            {
                string[] rowValues = new string[] {
                    "True",
                    item.ProductName,
                    item.ColorName,
                    item.CapacityName,
                    item.Price.ToString(),
                    item.Quantity.ToString()
                };

                DataGridView_Product.Rows.Add(rowValues);
            }

        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _import.EmployeeId = 1;
            _import.InternalCode = Text_InternalCode.Text;
            _import.DistributorId = int.Parse(ComboBox_Distributor.SelectedValue!.ToString()!);
            _import.Price = int.Parse(Text_Price.Text);
            _import.ImportDate = DateTime.Now;


            if (_import.Id == 0)
            {
                await _importBillService.Create(_import);
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new ImportControl());
        }
    }
}
