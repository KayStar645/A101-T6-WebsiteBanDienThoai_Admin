using Domain.DTOs;
using Services.Common;
using Services.Interfaces;
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
            Text_Price.Enabled = false;
            Text_EmployeeName.Enabled = false;
            Text_EmployeeName.Text = ServiceCommon.AuthRespone.UserName;

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
                DataGridView_Product.ReadOnly = true;
                Button_AddProduct.Visible = false;
                Button_Save.Visible = false;

                Text_InternalCode.Text = result.InternalCode;
                DateTime_ImportDate.Value = result.ImportDate;
                ComboBox_Distributor.Items.Add(result.DistributorName);
                ComboBox_Distributor.StartIndex = 0;
                ComboBox_Distributor.Enabled = false;
                Text_EmployeeName.Text = result.EmployeeInternalCode + "_" + result.EmployeeName;
                Text_Price.Text = Util.AddCommas(result.Price);

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

        private void CalculateBill()
        {
            long sum = 0;

            foreach (var item in _import.Details!)
            {
                if(item.Quantity == null || item.Price == null)
                {
                    continue;
                }

                sum += ((long)item.Quantity! * (long)item.Price!);
            }

            Text_Price.Text = Util.AddCommas(sum);
        }

        private void LoadProduct()
        {
            DataGridView_Product.Rows.Clear();

            foreach (DetailImportDto item in _import.Details)
            {
                string[] rowValues = new string[] {
                    "True",
                    item.ProductId.ToString(),
                    item.ProductInternalCode,
                    item.ProductName,
                    item.ColorName,
                    item.CapacityName,
                    item.Price != null ? Util.AddCommas(item.Price, "") : "0",
                    item.Quantity != null ? item.Quantity.ToString() : "0",
                };

                DataGridView_Product.Rows.Add(rowValues);
            }

        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _import.EmployeeId = ServiceCommon.AuthRespone.Id;
            _import.InternalCode = Text_InternalCode.Text;
            _import.DistributorId = int.Parse(ComboBox_Distributor.SelectedValue!.ToString()!);
            _import.Price = long.Parse(Util.DeleteCommas(Text_Price.Text));
            _import.ImportDate = DateTime.Now;


            if (_import.Id == 0)
            {
                await _importBillService.Create(_import);
            }

            Util.LoadControl(this, new ImportControl());
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new ImportControl());
        }

        private void Text_Price_KeyUp(object sender, KeyEventArgs e)
        {
            Util.AddCommasOnKeyUp(sender);
        }

        private void Text_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.IsNumber(e);
        }

        private void DataGridView_Product_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = DataGridView_Product.CurrentRow.Cells;
            bool selected = bool.Parse(cells["Product_Select"].FormattedValue.ToString()!);
            int id = int.Parse(cells["ProductId"].Value.ToString()!);

            if (e.ColumnIndex == 0 || DataGridView_Product.ReadOnly)
            {
                return;
            }

            int index = _import.Details!.FindIndex(t => t.ProductId == id);

            if (!selected)
            {
                return;
            }

            if (index == -1)
            {
                return;
            }

            try
            {
                _import.Details[index].Quantity = int.Parse(cells["Quantity"].Value.ToString()!);
                _import.Details[index].Price = long.Parse(Util.DeleteCommas(cells["Price"].Value.ToString()!));

                if(long.Parse(cells["Price"].Value.ToString()!) > 10)
                {
                    cells["Price"].Value = long.Parse(cells["Price"].Value.ToString()!);
                }

                cells["Quantity"].Value = int.Parse(cells["Quantity"].Value.ToString()!);

                CalculateBill();
            }
            catch (Exception)
            {
            }
        }

        private void DataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView_Product.CurrentRow == null)
            {
                return;
            }

            DataGridViewCellCollection cells = DataGridView_Product.CurrentRow.Cells;
            bool selected = bool.Parse(cells["Product_Select"].FormattedValue.ToString()!);
            int id = int.Parse(cells["ProductId"].Value.ToString()!);

            if (e.ColumnIndex != 0 || DataGridView_Product.ReadOnly)
            {
                return;
            }

            if (selected)
            {
                int index = _import.Details!.FindIndex(t => t.ProductId == id);

                cells["Product_Select"].Value = "False";

                if (index >= 0)
                {
                    _import.Details!.RemoveAt(index);
                }
            }
            else
            {
                cells["Product_Select"].Value = "True";

                _import.Details!.Add(new DetailImportDto()
                {
                    ProductId = id,
                    ProductInternalCode = cells["InternalCode"].Value.ToString(),
                    ProductName = cells["Product_Name"].Value.ToString(),
                    ColorName = cells["ColorName"].Value.ToString(),
                    CapacityName = cells["CapacityName"].Value.ToString(),
                    Price = long.Parse(Util.DeleteCommas(cells["Price"].Value.ToString()!)),
                    Quantity = int.Parse(cells["Quantity"].Value.ToString()!),
                });
            }

            CalculateBill();
        }
    }
}
