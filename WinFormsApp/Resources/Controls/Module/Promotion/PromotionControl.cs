using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Promotion
{
    public partial class PromotionControl : UserControl
    {
        private readonly IPromotionService _promotionService;
        public static Guna2Button _refreshButton = new Guna2Button();
        (List<PromotionDto> list, int totalCount, int pageNumber) _result;
        int _currPage = 1;

        public PromotionControl()
        {

            InitializeComponent();

            _promotionService = Program.container.GetInstance<IPromotionService>();
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
            //FlowLayoutPanel_Paginator.Controls.Clear();

            //for (int i = 1; i <= _result.pageNumber; i++)
            //{
            //    PaginatorButton button = new(i.ToString(), Button_Paginator_Click);

            //    FlowLayoutPanel_Paginator.Controls.Add(button);
            //}

            //if (_result.pageNumber > 0)
            //{
            //    FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.RoyalBlue;
            //    FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.White;
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

            LoadDataAsync();
        }

        public async void LoadDataAsync()
        {
            _result = await _promotionService.GetList("Name", _currPage, 15, "");

            DataGridView_Listing.DataSource = _result.list;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new PromotionDetailControl());
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;
            PromotionDto formData = new()
            {
                Id = int.Parse(selected["Id"].FormattedValue.ToString()),
                InternalCode = selected["InternalCode"].FormattedValue.ToString(),
                Name = selected["Product_name"].FormattedValue.ToString(),
            };

            if (e.ColumnIndex == 0)
            {
                Util.LoadControl(this, new PromotionDetailControl());
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _promotionService.Delete(formData.Id);
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
