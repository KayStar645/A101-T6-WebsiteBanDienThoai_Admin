using Controls.UI;
using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Import
{
    public partial class ImportControl : UserControl
    {
        private readonly IImportBillService _importService;
        public static Guna2Button _refreshButton = new Guna2Button();
        (List<ImportBillDto> list, int totalCount, int pageNumber) _result;
        int _currPage = 1;

        public ImportControl()
        {
            InitializeComponent();

            _importService = Program.container.GetInstance<IImportBillService>();
            _refreshButton = Button_Refresh;

            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            _refreshButton = Button_Refresh;

            if (!Util.CheckPermission("ImportBill.Update"))
            {
                Button_Edit.Text = "Xem";
            }

            if (!Util.CheckPermission("ImportBill.Create"))
            {
                Button_Create.Visible = false;
            }

            await LoadData();

            Paginator();
        }

        private void Paginator()
        {
            Util.LoadControl(TableLayoutPanel_Paginator, new Paginator(_result.pageNumber, _currPage, Button_Paginator_Click), DockStyle.Right);
        }

        private async void Button_Paginator_Click(int page)
        {
            _currPage = page;

            await LoadData();
        }

        public async Task LoadData()
        {
            _result = await _importService.GetList("InternalCode", _currPage, 15, Text_Search.Text);

            DataGridView_Listing.Rows.Clear();

            foreach (var item in _result.list)
            {
                string[] rows = new string[]
                {
                    "",
                    item.InternalCode,
                    item.EmployeeInternalCode + "_" + item.EmployeeName,
                    item.DistributorInternalCode + "_" + item.DistributorName,
                    item.ImportDate.ToString("dd/MM/yyyy"),
                    Util.AddCommas(item.Price, ""),
                    item.Id.ToString(),
                };

                DataGridView_Listing.Rows.Add(rows);
            }
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new ImportDetailControl());
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;

            if (e.ColumnIndex == 0)
            {
                int id = int.Parse(selected["Id"].FormattedValue.ToString());

                Util.LoadControl(this, new ImportDetailControl(id));
            }

        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
            _currPage = 1;
            Text_Search.Text = string.Empty;

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
    }
}
