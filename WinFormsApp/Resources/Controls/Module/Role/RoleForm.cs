using Common.Type;
using Domain.ModelViews;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Services.Interfaces;
using System.Linq;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Role
{
    public partial class RoleForm : Form
    {
        IRoleService _RoleService;
        IPermissionService _PermissionService;
        RoleVM _RoleVM = new();
        Dictionary<string, List<Option>> _GroupPermissions = new();

        public RoleForm()
        {
            InitializeComponent();

            _RoleVM.Id = 0;

            OnInit();
        }

        public RoleForm(int id)
        {
            InitializeComponent();

            _RoleVM.Id = id;

            OnInit();
        }

        private async void OnInit()
        {
            _RoleService = Program.container.GetInstance<IRoleService>();
            _PermissionService = Program.container.GetInstance<IPermissionService>();


            DesktopLocation = new Point((Screen.PrimaryScreen!.Bounds.Width - Width), 0);
            Height = Screen.PrimaryScreen.Bounds.Height;

            if (_RoleVM.Id > 0)
            {
                _RoleVM = await _RoleService.GetDetail(_RoleVM.Id);
            }
            else
            {
                _RoleVM.PermissionsName = new List<string>();
            }

            GroupPermission(_PermissionService.GetRequiredPermissions());
            LoadData();
        }

        private void GroupPermission(List<string> permissions)
        {
            foreach (string item in permissions)
            {
                string[] parts = item.Split('.');

                string type = parts[0];
                string action = parts[1];

                if (!_GroupPermissions.ContainsKey(type))
                {
                    _GroupPermissions[type] = new List<Option>();
                }

                if (_RoleVM.Id > 0)
                {
                    if (_RoleVM.PermissionsName != null && _RoleVM.PermissionsName.Contains(item))
                    {
                        _GroupPermissions[type].Add(new Option()
                        {
                            label = action,
                            value = "True"
                        });
                    }
                    else
                    {
                        _GroupPermissions[type].Add(new Option()
                        {
                            label = action,
                            value = "False"
                        });
                    }
                }
                else
                {
                    _GroupPermissions[type].Add(new Option()
                    {
                        label = action,
                        value = "False"
                    });
                }
            }
        }

        private void LoadData()
        {
            if (_RoleVM.Id > 0)
            {
                Label_Heading.Text = "Cập nhập quyền " + _RoleVM.Name;
                Text_Name.Text = _RoleVM.Name;
            }
            else
            {
                Label_Heading.Text = "Thêm mới quyền";
            }

            foreach (KeyValuePair<string, List<Option>> item in _GroupPermissions)
            {
                Panel child = RoleItem(item);

                Util.AddControl(Panel_Body, child, DockStyle.Top);
            }
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _RoleVM.Name = Text_Name.Text;

            try
            {
                if(_RoleVM.Id > 0)
                {
                    await _RoleService.Update(_RoleVM);
                }
                else
                {
                    await _RoleService.Create(_RoleVM);
                }

                Close();
                RoleControl._refreshButton.PerformClick();
            }
            catch (Exception err)
            {
                Dialog_Notification.Show(err.Message);
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Panel RoleItem(KeyValuePair<string, List<Option>> item)
        {
            Panel role = new();

            role.Controls.Add(RoleItems(item));
            role.Controls.Add(RoleCollapseButton(item.Key));
            role.Dock = DockStyle.Top;
            role.Location = new Point(0, 0);
            role.MaximumSize = new Size(0, 300);
            role.MinimumSize = new Size(0, 40);
            role.Name = "Panel_Role";
            role.Size = new Size(474, 300);
            role.TabIndex = 0;
            role.Margin = new Padding(0, 0, 0, 12);

            return role;
        }

        private Guna2DataGridView RoleItems(KeyValuePair<string, List<Option>> item)
        {
            Guna2DataGridView DataGridView_Listing = new();
            DataGridViewCellStyle dataGridViewCellStyle1 = new();
            DataGridViewCellStyle dataGridViewCellStyle2 = new();
            DataGridViewCellStyle dataGridViewCellStyle3 = new();
            DataGridViewCellStyle dataGridViewCellStyle4 = new();
            DataGridViewCheckBoxColumn SelectRole = new();
            DataGridViewTextBoxColumn RoleName = new();
            DataGridViewTextBoxColumn Prefix = new();

            SelectRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectRole.FalseValue = "False";
            SelectRole.HeaderText = "";
            SelectRole.Name = "SelectRole";
            SelectRole.ReadOnly = true;
            SelectRole.TrueValue = "True";
            SelectRole.Width = 40;

            RoleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoleName.DataPropertyName = "Name";
            RoleName.HeaderText = "Tên quyền";
            RoleName.Name = "RoleName";
            RoleName.ReadOnly = true;
            RoleName.Resizable = DataGridViewTriState.True;
            RoleName.SortMode = DataGridViewColumnSortMode.NotSortable;

            Prefix.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prefix.HeaderText = "Prefix";
            Prefix.Name = "Prefix";
            Prefix.ReadOnly = true;
            Prefix.Visible = false;
            Prefix.Resizable = DataGridViewTriState.True;
            Prefix.SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;


            DataGridView_Listing.AllowUserToAddRows = false;
            DataGridView_Listing.AllowUserToDeleteRows = false;
            DataGridView_Listing.AllowUserToResizeRows = false;
            DataGridView_Listing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_Listing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_Listing.ColumnHeadersHeight = 40;
            DataGridView_Listing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Listing.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_Listing.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.Location = new Point(0, 40);
            DataGridView_Listing.Margin = new Padding(0);
            DataGridView_Listing.ReadOnly = true;
            DataGridView_Listing.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_Listing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_Listing.RowHeadersVisible = false;
            DataGridView_Listing.RowHeadersWidth = 51;
            DataGridView_Listing.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.RowTemplate.Height = 40;
            DataGridView_Listing.Size = new Size(474, 260);
            DataGridView_Listing.TabIndex = 8;
            DataGridView_Listing.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_Listing.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_Listing.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_Listing.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_Listing.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_Listing.ThemeStyle.BackColor = Color.White;
            DataGridView_Listing.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_Listing.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_Listing.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridView_Listing.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_Listing.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Listing.ThemeStyle.HeaderStyle.Height = 40;
            DataGridView_Listing.ThemeStyle.ReadOnly = true;
            DataGridView_Listing.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_Listing.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_Listing.ThemeStyle.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Listing.ThemeStyle.RowsStyle.Height = 40;
            DataGridView_Listing.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);

            DataGridView_Listing.Dock = DockStyle.Fill;
            DataGridView_Listing.BringToFront();
            DataGridView_Listing.Columns.AddRange(new DataGridViewColumn[] { SelectRole, Prefix, RoleName });

            DataGridView_Listing.CellClick += DataGridView_Listing_CellClick;

            foreach (var option in item.Value)
            {
                DataGridView_Listing.Rows.Add(new string[]
                {
                    option.value,
                    item.Key,
                    option.label,
                });
            }


            return DataGridView_Listing;
        }

        private Guna2Button RoleCollapseButton(string name)
        {
            Guna2Button Btn_Scroll = new();
            CustomizableEdges customizableEdges5 = new();
            CustomizableEdges customizableEdges6 = new();

            Btn_Scroll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            Btn_Scroll.Cursor = Cursors.Hand;
            Btn_Scroll.CustomizableEdges = customizableEdges5;
            Btn_Scroll.DisabledState.BorderColor = Color.DarkGray;
            Btn_Scroll.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn_Scroll.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn_Scroll.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn_Scroll.Dock = DockStyle.Top;
            Btn_Scroll.FillColor = Color.Gray;
            Btn_Scroll.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Scroll.ForeColor = Color.White;
            Btn_Scroll.Image = Properties.Resources.white_arrow_down;
            Btn_Scroll.ImageAlign = HorizontalAlignment.Right;
            Btn_Scroll.Location = new Point(0, 0);
            Btn_Scroll.Name = "Btn_Scroll";
            Btn_Scroll.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Btn_Scroll.Size = new Size(474, 40);
            Btn_Scroll.TabIndex = 0;
            Btn_Scroll.Text = name;
            Btn_Scroll.TextAlign = HorizontalAlignment.Left;
            Btn_Scroll.Click += Btn_Scroll_Click;

            return Btn_Scroll;
        }

        private void Btn_Scroll_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            Util.Collapse(btn.Checked, btn.Parent);
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 0)
            {
                return;
            }

            Guna2DataGridView guna2DataGridView = (Guna2DataGridView)sender;

            DataGridViewCellCollection cells = guna2DataGridView.CurrentRow.Cells;
            bool check = bool.Parse(cells["SelectRole"].FormattedValue.ToString());
            string permission = cells["Prefix"].Value.ToString() + "." + cells["RoleName"].Value.ToString();

            if(check) 
            {
                cells["SelectRole"].Value = "False";

                _RoleVM.PermissionsName.Remove(permission);
            }
            else
            {
                cells["SelectRole"].Value = "True";

                _RoleVM.PermissionsName.Add(permission);
            }
        }
    }
}
