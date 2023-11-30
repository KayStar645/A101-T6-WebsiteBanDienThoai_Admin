namespace WinFormsApp.Resources.Controls.Module.User
{
    partial class UserAssignRoleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Dialog_Notification = new Guna.UI2.WinForms.Guna2MessageDialog();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            Text_Name = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            DataGridView_Listing = new Guna.UI2.WinForms.Guna2DataGridView();
            SelectRole = new DataGridViewCheckBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            UserRoles = new DataGridViewTextBoxColumn();
            RolePermissions = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            IsDeleted = new DataGridViewTextBoxColumn();
            Label_Heading = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            FormBorderLess_Distributor = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Dialog_Notification
            // 
            Dialog_Notification.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            Dialog_Notification.Caption = "Thông báo";
            Dialog_Notification.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            Dialog_Notification.Parent = null;
            Dialog_Notification.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            Dialog_Notification.Text = null;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(Text_Name, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Controls.Add(DataGridView_Listing, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 35);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(8, 12, 4, 0);
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(511, 469);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 30);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 2;
            label3.Text = "Tên người dùng";
            // 
            // Text_Name
            // 
            Text_Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Text_Name.Animated = true;
            Text_Name.BorderRadius = 5;
            Text_Name.CustomizableEdges = customizableEdges1;
            Text_Name.DefaultText = "";
            Text_Name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Name.Enabled = false;
            Text_Name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Name.ForeColor = Color.Black;
            Text_Name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Name.Location = new Point(131, 21);
            Text_Name.Margin = new Padding(3, 4, 3, 4);
            Text_Name.Name = "Text_Name";
            Text_Name.PasswordChar = '\0';
            Text_Name.PlaceholderText = "Tên người dùng";
            Text_Name.SelectedText = "";
            Text_Name.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_Name.Size = new Size(373, 36);
            Text_Name.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 85);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 4;
            label1.Text = "Vai trò";
            // 
            // DataGridView_Listing
            // 
            DataGridView_Listing.AllowUserToAddRows = false;
            DataGridView_Listing.AllowUserToDeleteRows = false;
            DataGridView_Listing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridView_Listing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_Listing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_Listing.ColumnHeadersHeight = 40;
            DataGridView_Listing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Listing.Columns.AddRange(new DataGridViewColumn[] { SelectRole, UserName, UserRoles, RolePermissions, Id, IsDeleted });
            tableLayoutPanel3.SetColumnSpan(DataGridView_Listing, 2);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_Listing.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_Listing.Dock = DockStyle.Fill;
            DataGridView_Listing.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.Location = new Point(8, 122);
            DataGridView_Listing.Margin = new Padding(0);
            DataGridView_Listing.Name = "DataGridView_Listing";
            DataGridView_Listing.ReadOnly = true;
            DataGridView_Listing.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridView_Listing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_Listing.RowHeadersVisible = false;
            DataGridView_Listing.RowHeadersWidth = 51;
            DataGridView_Listing.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.RowTemplate.Height = 40;
            DataGridView_Listing.Size = new Size(499, 347);
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
            DataGridView_Listing.CellClick += DataGridView_Listing_CellClick;
            // 
            // SelectRole
            // 
            SelectRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectRole.FalseValue = "False";
            SelectRole.HeaderText = "";
            SelectRole.Name = "SelectRole";
            SelectRole.ReadOnly = true;
            SelectRole.TrueValue = "True";
            SelectRole.Width = 40;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "Name";
            UserName.DividerWidth = 1;
            UserName.HeaderText = "Vai trò";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
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
            RolePermissions.HeaderText = "RolePermission";
            RolePermissions.Name = "RolePermissions";
            RolePermissions.ReadOnly = true;
            RolePermissions.Visible = false;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // IsDeleted
            // 
            IsDeleted.DataPropertyName = "IsDeleted";
            IsDeleted.HeaderText = "IsDeleted";
            IsDeleted.Name = "IsDeleted";
            IsDeleted.ReadOnly = true;
            IsDeleted.Visible = false;
            // 
            // Label_Heading
            // 
            Label_Heading.Anchor = AnchorStyles.None;
            Label_Heading.AutoSize = true;
            Label_Heading.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Heading.Location = new Point(212, 8);
            Label_Heading.Name = "Label_Heading";
            Label_Heading.Size = new Size(86, 19);
            Label_Heading.TabIndex = 0;
            Label_Heading.Text = "Người dùng";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.WhiteSmoke;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(Button_Cancel, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 504);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(7, 0, 7, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(511, 49);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Anchor = AnchorStyles.Left;
            Button_Cancel.Animated = true;
            Button_Cancel.AnimatedGIF = true;
            Button_Cancel.BorderRadius = 8;
            Button_Cancel.CustomizableEdges = customizableEdges3;
            Button_Cancel.DisabledState.BorderColor = Color.DarkGray;
            Button_Cancel.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Cancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Cancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Cancel.FillColor = Color.DarkGray;
            Button_Cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Cancel.ForeColor = Color.White;
            Button_Cancel.Location = new Point(10, 4);
            Button_Cancel.Margin = new Padding(3, 2, 3, 2);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Cancel.Size = new Size(70, 40);
            Button_Cancel.TabIndex = 1;
            Button_Cancel.Text = "Hủy";
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(100, 88, 255);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.11203F));
            tableLayoutPanel2.Controls.Add(Label_Heading, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.ForeColor = Color.White;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(511, 35);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // FormBorderLess_Distributor
            // 
            FormBorderLess_Distributor.AnimateWindow = true;
            FormBorderLess_Distributor.AnimationInterval = 300;
            FormBorderLess_Distributor.BorderRadius = 10;
            FormBorderLess_Distributor.ContainerControl = this;
            FormBorderLess_Distributor.DockIndicatorColor = Color.Black;
            FormBorderLess_Distributor.DockIndicatorTransparencyValue = 0.6D;
            FormBorderLess_Distributor.TransparentWhileDrag = true;
            // 
            // UserAssignRoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 553);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAssignRoleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAssignRoleForm";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Notification;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Text_Name;
        private Label Label_Heading;
        private TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormBorderLess_Distributor;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Listing;
        private DataGridViewCheckBoxColumn SelectRole;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserRoles;
        private DataGridViewTextBoxColumn RolePermissions;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IsDeleted;
    }
}