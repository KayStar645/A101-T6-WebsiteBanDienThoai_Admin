using Domain.DTOs;
using Services.Interfaces;

namespace WinFormsApp.Resources.Controls.Module.User
{
    public partial class UserAssignRoleForm : Form
    {
        IAuthService _AuthService;
        IRoleService _RoleService;

        UserDto _user = new();

        public UserAssignRoleForm()
        {
            InitializeComponent();

            _AuthService = Program.container.GetInstance<IAuthService>();
            _RoleService = Program.container.GetInstance<IRoleService>();

            _user.UserName = "";

            OnInit();
        }

        public UserAssignRoleForm(string name)
        {
            InitializeComponent();

            _AuthService = Program.container.GetInstance<IAuthService>();
            _RoleService = Program.container.GetInstance<IRoleService>();

            _user.UserName = name;

            OnInit();
        }

        public async void OnInit()
        {
            await LoadData();
            await LoadRole();
        }

        public async Task LoadRole()
        {
            var result = await _RoleService.GetList();

            DataGridView_Listing.DataSource = result;

            if(_user.UserName != "" && _user.Roles != null)
            {
                foreach (DataGridViewRow item in DataGridView_Listing.Rows)
                {
                    string role = item.Cells["Name"].Value.ToString()!;

                    if (_user.Roles.Contains(role))
                    {
                        item.Cells["SelectRole"].Value = "True";
                    }
                }
            }
        }

        public async Task LoadData()
        {
            if (_user.UserName != "")
            {
                _user = await _AuthService.GetDetail(_user.UserName!);
                Label_Heading.Text = "Cập nhập người dùng " + _user.UserName;
                Text_Name.Text = _user.UserName;
            }
            else
            {
                Label_Heading.Text = "Thêm mới người dùng";
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            UserAssignRoleControl._refreshButton.PerformClick();
            Close();
        }

        private async void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != 0) 
            {
                return;
            }

            DataGridViewCellCollection cells = DataGridView_Listing.CurrentRow.Cells;
            bool check = bool.Parse(cells["SelectRole"].FormattedValue.ToString());
            int id = int.Parse(cells["Id"].Value.ToString());

            if(check)
            {
                await _RoleService.RevokeRole(new Domain.ModelViews.AssignRoleVM()
                {
                    RoleId = id,
                    UserId = (int)_user.Id,
                });

                cells["SelectRole"].Value = "False";
            }
            else
            {
                await _RoleService.AssignRoles(new Domain.ModelViews.AssignRoleVM()
                {
                    RoleId = id,
                    UserId = (int)_user.Id,
                });

                cells["SelectRole"].Value = "True";
            }
        }
    }
}
