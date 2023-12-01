using Controls.UI;
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

        private async void InitializeAsync()
        {
            _refreshButton = Button_Refresh;

            if (!Util.CheckPermission("Promotion.Create"))
            {
                Button_Create.Visible = false;
            }

            if (!Util.CheckPermission("Promotion.Update"))
            {
                Button_Edit.Text = "Xem";
            }

            Paginator();

            await LoadData();
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
            _result = await _promotionService.GetList("Name", _currPage, 15, Text_Search.Text);

            foreach (PromotionDto item in _result.list)
            {
                item.Status = Domain.Entities.Promotion.GetStatusMapping(item.Status).FirstOrDefault().statusName;
                item.Type = Domain.Entities.Promotion.GetTypeMapping(item.Type).FirstOrDefault().typeName;
            }

            DataGridView_Listing.DataSource = _result.list;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new PromotionDetailControl());
        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
            _currPage = 1;
            Text_Search.Text = string.Empty;

            await LoadData();
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

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(DataGridView_Listing.CurrentRow.Cells["Id"].Value.ToString()!);

            if (e.ColumnIndex == 0)
            {
                Util.LoadControl(this, new PromotionDetailControl(id));
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _promotionService.Delete(id);
                Button_Refresh.PerformClick();
            }
        }
    }
}
