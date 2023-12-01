using Controls.UI;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Role
{
    public partial class RoleControl : UserControl
    {
        private readonly IRoleService _RoleService;
        public static Guna2Button _refreshButton = new Guna2Button();
        List<Domain.Entities.Role> _result;

        public RoleControl()
        {

            InitializeComponent();

            _RoleService = Program.container.GetInstance<IRoleService>();
            _refreshButton = Button_Refresh;

            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            _refreshButton = Button_Refresh;

            if (!Util.CheckPermission("Role.Create"))
            {
                Button_Create.Visible = false;
            }

            if (!Util.CheckPermission("Role.Update"))
            {
                Button_Edit.Text = "Xem";
            }

            await LoadData();
        }

        public async Task LoadData()
        {
            _result = await _RoleService.GetList();

            DataGridView_Listing.DataSource = _result;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new RoleForm(), true);
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;

            if (e.ColumnIndex == 0)
            {
                Util.LoadForm(new RoleForm(int.Parse(selected["Id"].Value.ToString())), true);
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
            await LoadData();

            Timer_Debounce.Stop();
        }
    }
}
