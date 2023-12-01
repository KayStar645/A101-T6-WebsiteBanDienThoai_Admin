using Controls.UI;
using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Parameter
{
    public partial class ParameterControl : UserControl
    {

        ISpecificationsService _specificationsService;
        (List<SpecificationsDto> list, int totalCount, int pageNumber) _result;
        public static Guna2Button _refreshBtn;
        int _currPage = 1;

        public ParameterControl()
        {
            InitializeComponent();

            OnInit();
        }

        private async void OnInit()
        {
            _specificationsService = Program.container.GetInstance<ISpecificationsService>();
            _refreshBtn = Button_Refresh;


            if (!Util.CheckPermission("Specifications.Create"))
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

        private void Button_Create_Click(object sender, EventArgs e)
        {
            ParameterItem item = new();

            Util.AddControl(Panel_Container, item, DockStyle.Top);
        }

        private async Task LoadData()
        {
            _result = await _specificationsService.GetList("Name", _currPage, 10, Text_Search.Text);

            Panel_Container.Controls.Clear();

            foreach (var item in _result.list)
            {
                ParameterItem parameter = new(item);

                Util.AddControl(Panel_Container, parameter, DockStyle.Top);
            }
        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
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
    }
}
