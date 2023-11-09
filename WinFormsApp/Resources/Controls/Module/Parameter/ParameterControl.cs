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

        public ParameterControl()
        {
            InitializeComponent();

            _specificationsService = Program.container.GetInstance<ISpecificationsService>();
            _refreshBtn = Button_Refresh;

            LoadParemeter();
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            ParameterItem item = new();

            Util.AddControl(Panel_Container, item, DockStyle.Top);
        }

        private async void LoadParemeter()
        {
            _result = await _specificationsService.GetList();

            Panel_Container.Controls.Clear();

            foreach (var item in _result.list)
            {
                ParameterItem parameter = new(item);

                Util.AddControl(Panel_Container, parameter, DockStyle.Top);
            }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            LoadParemeter();
        }
    }
}
