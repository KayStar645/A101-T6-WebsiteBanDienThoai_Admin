namespace WinFormsApp.Resources.Controls.Module.Role
{
    partial class RoleControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TableLayoutPanel_Body = new TableLayoutPanel();
            DataGridView_Listing = new Guna.UI2.WinForms.Guna2DataGridView();
            edit = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            RoleName = new DataGridViewTextBoxColumn();
            UserRoles = new DataGridViewTextBoxColumn();
            RolePermissions = new DataGridViewTextBoxColumn();
            IsDeleted = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            Button_Create = new Guna.UI2.WinForms.Guna2Button();
            Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            Dialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            Timer_Debounce = new System.Windows.Forms.Timer(components);
            TableLayoutPanel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel_Body
            // 
            TableLayoutPanel_Body.ColumnCount = 2;
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 412F));
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.Controls.Add(DataGridView_Listing, 0, 0);
            TableLayoutPanel_Body.Controls.Add(tableLayoutPanel1, 1, 0);
            TableLayoutPanel_Body.Dock = DockStyle.Fill;
            TableLayoutPanel_Body.Location = new Point(0, 0);
            TableLayoutPanel_Body.Margin = new Padding(0);
            TableLayoutPanel_Body.Name = "TableLayoutPanel_Body";
            TableLayoutPanel_Body.RowCount = 1;
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.Size = new Size(852, 626);
            TableLayoutPanel_Body.TabIndex = 4;
            // 
            // DataGridView_Listing
            // 
            DataGridView_Listing.AllowUserToAddRows = false;
            DataGridView_Listing.AllowUserToDeleteRows = false;
            DataGridView_Listing.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            DataGridView_Listing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DataGridView_Listing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DataGridView_Listing.ColumnHeadersHeight = 40;
            DataGridView_Listing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Listing.Columns.AddRange(new DataGridViewColumn[] { edit, Id, RoleName, UserRoles, RolePermissions, IsDeleted });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            DataGridView_Listing.DefaultCellStyle = dataGridViewCellStyle11;
            DataGridView_Listing.Dock = DockStyle.Fill;
            DataGridView_Listing.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.Location = new Point(0, 0);
            DataGridView_Listing.Margin = new Padding(0);
            DataGridView_Listing.Name = "DataGridView_Listing";
            DataGridView_Listing.ReadOnly = true;
            DataGridView_Listing.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            DataGridView_Listing.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            DataGridView_Listing.RowHeadersVisible = false;
            DataGridView_Listing.RowHeadersWidth = 51;
            DataGridView_Listing.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.RowTemplate.Height = 40;
            DataGridView_Listing.Size = new Size(412, 626);
            DataGridView_Listing.TabIndex = 7;
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
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(100, 88, 255);
            edit.DefaultCellStyle = dataGridViewCellStyle9;
            edit.FillWeight = 20F;
            edit.HeaderText = "";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Sửa";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 6;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Id.DefaultCellStyle = dataGridViewCellStyle10;
            Id.HeaderText = "Mã quyền";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 120;
            // 
            // RoleName
            // 
            RoleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoleName.DataPropertyName = "Name";
            RoleName.DividerWidth = 1;
            RoleName.FillWeight = 15.0120726F;
            RoleName.HeaderText = "Tên quyền";
            RoleName.MinimumWidth = 6;
            RoleName.Name = "RoleName";
            RoleName.ReadOnly = true;
            // 
            // UserRoles
            // 
            UserRoles.DataPropertyName = "UserRoles";
            UserRoles.HeaderText = "UserRoles";
            UserRoles.Name = "UserRoles";
            UserRoles.ReadOnly = true;
            UserRoles.Visible = false;
            // 
            // RolePermissions
            // 
            RolePermissions.DataPropertyName = "RolePermissions";
            RolePermissions.HeaderText = "RolePermissions";
            RolePermissions.Name = "RolePermissions";
            RolePermissions.ReadOnly = true;
            RolePermissions.Visible = false;
            // 
            // IsDeleted
            // 
            IsDeleted.DataPropertyName = "IsDeleted";
            IsDeleted.HeaderText = "Deleted";
            IsDeleted.Name = "IsDeleted";
            IsDeleted.ReadOnly = true;
            IsDeleted.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Controls.Add(Button_Create, 0, 0);
            tableLayoutPanel1.Controls.Add(Button_Refresh, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(580, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(269, 620);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // Button_Create
            // 
            Button_Create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button_Create.AnimatedGIF = true;
            Button_Create.BorderRadius = 8;
            Button_Create.CustomizableEdges = customizableEdges5;
            Button_Create.DisabledState.BorderColor = Color.DarkGray;
            Button_Create.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Create.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Create.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Create.FillColor = Color.FromArgb(100, 88, 255);
            Button_Create.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Create.ForeColor = Color.White;
            Button_Create.Location = new Point(178, 0);
            Button_Create.Margin = new Padding(0);
            Button_Create.Name = "Button_Create";
            Button_Create.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Button_Create.Size = new Size(91, 41);
            Button_Create.TabIndex = 2;
            Button_Create.Text = "Thêm mới";
            Button_Create.Click += Button_Create_Click;
            // 
            // Button_Refresh
            // 
            Button_Refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button_Refresh.AnimatedGIF = true;
            Button_Refresh.BorderRadius = 8;
            Button_Refresh.CustomizableEdges = customizableEdges7;
            Button_Refresh.DisabledState.BorderColor = Color.DarkGray;
            Button_Refresh.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Refresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Refresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Refresh.FillColor = Color.Green;
            Button_Refresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Refresh.ForeColor = Color.White;
            Button_Refresh.Location = new Point(76, 0);
            Button_Refresh.Margin = new Padding(0);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Button_Refresh.Size = new Size(91, 41);
            Button_Refresh.TabIndex = 3;
            Button_Refresh.Text = "Làm mới";
            Button_Refresh.Click += Button_Refresh_Click;
            // 
            // Dialog_Confirm
            // 
            Dialog_Confirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            Dialog_Confirm.Caption = "Thông báo";
            Dialog_Confirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            Dialog_Confirm.Parent = null;
            Dialog_Confirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            Dialog_Confirm.Text = "Bạn có chắc chắn muốn xóa chứ ?";
            // 
            // Timer_Debounce
            // 
            Timer_Debounce.Interval = 600;
            // 
            // RoleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel_Body);
            Name = "RoleControl";
            Size = new Size(852, 626);
            TableLayoutPanel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel TableLayoutPanel_Body;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Confirm;
        private System.Windows.Forms.Timer Timer_Debounce;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Listing;
        private DataGridViewButtonColumn edit;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn RoleName;
        private DataGridViewTextBoxColumn UserRoles;
        private DataGridViewTextBoxColumn RolePermissions;
        private DataGridViewTextBoxColumn IsDeleted;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button Button_Create;
        private Guna.UI2.WinForms.Guna2Button Button_Refresh;
    }
}
