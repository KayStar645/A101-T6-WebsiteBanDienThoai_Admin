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
        int _currPage = 1;

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

            await LoadData();
        }

        private async void Button_Paginator_Click(int page)
        {
            _currPage = page;

            await LoadData();
        }

        public async Task LoadData()
        {
            //_result = await _RoleService.GetList();

            //DataGridView_Listing.DataSource = _result;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new RoleForm(), true);
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;
            //RoleDto formData = new()
            //{
            //    Id = int.Parse(selected["Id"].Value.ToString()),
            //    InternalCode = selected["InternalCode"].Value.ToString(),
            //    Name = selected["_Name"].Value.ToString(),
            //    Sex = selected["Sex"].Value.ToString(),
            //    Birthday = DateTime.Parse(selected["Birthday"].Value.ToString()),
            //    Phone = selected["Phone"].Value.ToString(),
            //};

            //if (e.ColumnIndex == 0)
            //{
            //    Util.LoadForm(new RoleForm(formData), true);
            //}
            //else if (e.ColumnIndex == 1)
            //{
            //    DialogResult dialogResult = Dialog_Confirm.Show();

            //    if (dialogResult != DialogResult.Yes)
            //    {
            //        return;
            //    }

            //    Button_Refresh.PerformClick();
            //}
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

            Timer_Debounce.Stop();
        }
    }
}
