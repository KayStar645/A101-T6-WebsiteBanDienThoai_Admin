using Controls.UI;
using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp;
using WinFormsApp.Services;

namespace Controls.Module
{
    public partial class CustomerControl : UserControl
    {
        public static Guna2Button _refreshButton = new Guna2Button();

        private readonly ICustomerService _customerService;
        (List<CustomerDto> list, int totalCount, int pageNumber) _result;
        int _currPage = 1;

        public CustomerControl()
        {
            InitializeComponent();

            _customerService = Program.container.GetInstance<ICustomerService>();

            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            _result = await _customerService.GetList("Name", 1, 15, "");

            DataGridView_Listing.DataSource = _result.list;

            _refreshButton = Button_Refresh;

            Paginator();
        }

        private void Paginator()
        {
            Util.AddControl(TableLayoutPanel_Container, new Paginator(_result.pageNumber, _currPage, Button_Paginator_Click), DockStyle.Right);
        }

        private async void Button_Paginator_Click(int page)
        {
            _currPage = page;

            await LoadData();
        }

        public async Task LoadData()
        {
            _result = await _customerService.GetList("Name", _currPage, 15, Text_Search.Text);

            DataGridView_Listing.DataSource = _result.list;
        }


        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;
            CustomerDto formData = new()
            {
                Id = int.Parse(selected["Id"].FormattedValue.ToString()),
                InternalCode = selected["InternalCode"].FormattedValue.ToString(),
                Phone = selected["Phone"].FormattedValue.ToString(),
                Name = selected["_Name"].FormattedValue.ToString(),
                Address = selected["Address"].FormattedValue.ToString(),
            };

            Button_Refresh.PerformClick();
        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
            _currPage = 1;
            Text_Search.Text = string.Empty;

            await LoadData();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            Timer_Debounce.Stop();
            Timer_Debounce.Start();
        }

        private async void Timer_Debounce_Tick(object sender, EventArgs e)
        {
            _currPage = 1;
            Text_Search.Text = string.Empty;

            Paginator();
            await LoadData();
        }
    }
}
