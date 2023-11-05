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

        private void InitializeAsync()
        {
            _refreshButton = Button_Refresh;

            LoadDataAsync();

            Paginator();
        }

        private void Paginator()
        {
        }

        private async void Button_Paginator_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.White;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.Black;

            _currPage = int.Parse(button.Text);

            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.RoyalBlue;
            FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.White;

            LoadDataAsync();
        }

        public async void LoadDataAsync()
        {
            _result = await _importService.GetList("Name", _currPage, 15, "");

            DataGridView_Listing.DataSource = _result.list;
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
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                Button_Refresh.PerformClick();
            }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            Timer_Debounce.Stop();
            Timer_Debounce.Start();
        }

        private void Timer_Debounce_Tick(object sender, EventArgs e)
        {
            _currPage = 1;

            Paginator();

            LoadDataAsync();
        }
    }
}
