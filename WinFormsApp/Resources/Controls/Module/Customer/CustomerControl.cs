using Controls.UI;
using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp;


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

        public CustomerControl(List<CustomerDto> customers)
        {
            InitializeComponent();

            _customerService = Program.container.GetInstance<ICustomerService>();

            _refreshButton = Button_Refresh;

            LoadData(customers);
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
            //FlowLayoutPanel_Paginator.Controls.Clear();

            //for (int i = 1; i <= _result.pageNumber; i++)
            //{
            //	PaginatorButton button = new(i.ToString(), Button_Paginator_Click);

            //	FlowLayoutPanel_Paginator.Controls.Add(button);
            //}

            //if (_result.pageNumber > 0)
            //{
            //	FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.RoyalBlue;
            //	FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.White;
            //}
        }

        private async void Button_Paginator_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.White;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.Black;

            _currPage = int.Parse(button.Text);

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.RoyalBlue;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.White;

            _result = await _customerService.GetList("Name", _currPage, 15, "");


            LoadData(_result.list);
        }

        public void LoadData(List<CustomerDto> customers)
        {
            DataGridView_Listing.DataSource = customers;
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
            _result = await _customerService.GetList("Name", 1, 15, "");

            LoadData(_result.list);
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

            _result = await _customerService.GetList("Name", _currPage, 15, Text_Search.Text);

            LoadData(_result.list);
        }
    }
}
