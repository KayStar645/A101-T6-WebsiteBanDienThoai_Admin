using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Resources.Controls.Module.Import;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Order
{
    public partial class OrderDetailControl : UserControl
    {
        OrderDto _order;
        IOrderService _orderService;

        public OrderDetailControl(int id)
        {
            InitializeComponent();

            _order = new OrderDto()
            {
                Id = id
            };

            OnInit();
        }

        public OrderDetailControl()
        {
            InitializeComponent();

            _order = new OrderDto();

            _order.Id = 0;

            OnInit();
        }

        private async void OnInit()
        {
            _orderService = Program.container.GetInstance<IOrderService>();

            DateTime_ImportDate.Value = DateTime.Now;
            Text_Price.Enabled = false;

            await LoadData();
        }

        private async Task LoadData()
        {
            if (_order.Id > 0)
            {
                var result = await _orderService.GetDetail(_order.Id);

                _order = result;

                Text_Customer.Text = result.CustomerName;
                Text_InternalCode.Text = result.InternalCode;
                DateTime_ImportDate.Value = result.OrderDate;
                Text_EmployeeName.Text = result.EmployeeInternalCode + "_" + result.EmployeeName;
                Text_Price.Text = Util.AddCommas(result.Price);
                Text_Status.Text = Domain.Entities.Order.GetTypeMapping(result.Type).FirstOrDefault().typename;

                LoadProduct();

                if (result.Type == Domain.Entities.Order.TYPE_ORDER)
                {
                    Button_Save.Visible = true;
                    Button_Approve.Visible = true;
                    Button_Cancel.Visible = true;
                    Button_AddProduct.Visible = true;
                }
                else if (result.Type == Domain.Entities.Order.TYPE_APPROVE)
                {
                    Button_Transport.Visible = true;
                    DataGridView_Product.ReadOnly = true;
                }
                else if (result.Type == Domain.Entities.Order.TYPE_TRANSPORT)
                {
                    Button_Received.Visible = true;
                    DataGridView_Product.ReadOnly = true;
                }

            }
            else
            {
                _order = new OrderDto();
                _order.Details = new List<DetailOrderDto>();
            }
        }

        private void Button_AddProduct_Click(object sender, EventArgs e)
        {
            if (_order.Details.Count > 0)
            {
                Util.LoadForm(new OrderProductControl(OnSaveProduct, _order.Details), true);

            }
            else
            {
                Util.LoadForm(new OrderProductControl(OnSaveProduct), true);
            }
        }

        private void OnSaveProduct(List<DetailOrderDto> products)
        {
            _order.Details = products;

            LoadProduct();
            CalculateBill();
        }

        private void CalculateBill()
        {
            long sum = 0;

            if (_order.Details != null && _order.Details.Count == 0)
            {
                Text_Price.Text = Util.AddCommas(sum);

                return;
            }

            for (int i = 0; i < _order.Details!.Count; i++)
            {
                var item = _order.Details[i];
                long total = ((long)item.Quantity! * (long)item.Price!);

                sum += total;
                item.SumPrice = total;

                DataGridView_Product.Rows[i].Cells["SumPrice"].Value = Util.AddCommas(total, "");
            }

            Text_Price.Text = Util.AddCommas(sum);
        }

        private void LoadProduct()
        {
            DataGridView_Product.Rows.Clear();

            foreach (DetailOrderDto item in _order.Details)
            {
                string[] rowValues = new string[] {
                    "True",
                    item.ProductId.ToString(),
                    item.ProductInternalCode,
                    item.ProductName,
                    item.ColorName,
                    item.CapacityName,
                    Util.AddCommas(item.Price, ""),
                    Util.AddCommas(item.DiscountPrice, ""),
                    item.Quantity.ToString(),
                    Util.AddCommas(item.SumPrice, ""),
                };

                DataGridView_Product.Rows.Add(rowValues);
            }

        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _order.EmployeeId = 1;
            _order.InternalCode = Text_InternalCode.Text;
            _order.Price = long.Parse(Util.DeleteCommas(Text_Price.Text));
            _order.OrderDate = DateTime.Now;

            try
            {

                if (_order.Id > 0)
                {
                    await _orderService.Update(_order);
                }

                Util.LoadControl(this, new OrderControl());
            }
            catch (Exception ex)
            {
                Dialog_Notification.Show(ex.Message);
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new OrderControl());
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

            int index = _order.Details!.FindIndex(t => t.ProductId == id);

            if (!selected)
            {
                return;
            }

            if (index == -1)
            {
                return;
            }

            _order.Details[index].Quantity = int.Parse(cells["Quantity"].Value.ToString()!);

            CalculateBill();
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
                int index = _order.Details!.FindIndex(t => t.ProductId == id);

                cells["Product_Select"].Value = "False";

                if (index >= 0)
                {
                    _order.Details!.RemoveAt(index);
                }
            }
            else
            {
                cells["Product_Select"].Value = "True";

                _order.Details!.Add(new DetailOrderDto()
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

        private async void Button_Approve_Click(object sender, EventArgs e)
        {
            await _orderService.ChangeTypeOrder(_order.Id, Domain.Entities.Order.TYPE_APPROVE);

            Util.LoadControl(this, new OrderControl());
        }

        private async void Button_Received_Click(object sender, EventArgs e)
        {
            await _orderService.ChangeTypeOrder(_order.Id, Domain.Entities.Order.TYPE_RECEIVED);

            Util.LoadControl(this, new OrderControl());
        }

        private async void Button_Cancel_Click(object sender, EventArgs e)
        {
            await _orderService.ChangeTypeOrder(_order.Id, Domain.Entities.Order.TYPE_CANNEL);

            Util.LoadControl(this, new OrderControl());
        }

        private async void Button_Transport_Click(object sender, EventArgs e)
        {
            await _orderService.ChangeTypeOrder(_order.Id, Domain.Entities.Order.TYPE_TRANSPORT);

            Util.LoadControl(this, new OrderControl());
        }
    }
}
