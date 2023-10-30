using Controls.UI;
using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using SimpleInjector;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Distributor
{
    public partial class DistributorControl : UserControl
    {
        private readonly Container _container;
        private readonly IDistributorService _distributorService;
        public static Guna2Button _refreshButton = new Guna2Button();
        (List<DistributorDto> list, int totalCount, int pageNumber) _result;
        int _currPage = 1;

        public DistributorControl(Container container)
        {
            _container = container;

            InitializeComponent();

            _distributorService = _container.GetInstance<IDistributorService>();

            InitializeAsync();
        }

        public DistributorControl(Container container, List<DistributorDto> distributors)
        {
            _container = container;

            InitializeComponent();

            _distributorService = _container.GetInstance<IDistributorService>();

            _refreshButton = Button_Refresh;

            LoadData(distributors);
        }

        private async void InitializeAsync()
        {
            _result = await _distributorService.GetList("Name", 1, 15, "");

            DataGridView_Listing.DataSource = _result.list;

            _refreshButton = Button_Refresh;

            Paginator();
        }

        private void Paginator()
        {
            FlowLayoutPanel_Paginator.Controls.Clear();

            for (int i = 1; i <= _result.pageNumber; i++)
            {
                PaginatorButton button = new(i.ToString(), Button_Paginator_Click);

                FlowLayoutPanel_Paginator.Controls.Add(button);
            }

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.RoyalBlue;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.White;
        }

        private async void Button_Paginator_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.White;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.Black;

            _currPage = int.Parse(button.Text);

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.RoyalBlue;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.White;

            _result = await _distributorService.GetList("Name", _currPage, 15, "");


            LoadData(_result.list);
        }

        public void LoadData(List<DistributorDto> distributors)
        {
            DataGridView_Listing.DataSource = distributors;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new DistributorForm(_container), true);
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;
            DistributorDto formData = new()
            {
                Id = int.Parse(selected["Id"].FormattedValue.ToString()),
                InternalCode = selected["InternalCode"].FormattedValue.ToString(),
                Name = selected["_Name"].FormattedValue.ToString(),
                Address = selected["Address"].FormattedValue.ToString(),
                Phone = selected["Phone"].FormattedValue.ToString(),
            };

            if (e.ColumnIndex == 0)
            {
                Util.LoadForm(new DistributorForm(_container, formData), true);
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _distributorService.Delete(formData.Id);
                Button_Refresh.PerformClick();
            }
        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
            _result = await _distributorService.GetList("Name", 1, 15, "");

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

            _result = await _distributorService.GetList("Name", _currPage, 15, Text_Search.Text);

            LoadData(_result.list);
        }
    }
}
