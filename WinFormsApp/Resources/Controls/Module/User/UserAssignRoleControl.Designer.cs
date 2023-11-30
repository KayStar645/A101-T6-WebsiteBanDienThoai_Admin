namespace WinFormsApp.Resources.Controls.Module.User
{
    partial class UserAssignRoleControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Timer_Debounce = new System.Windows.Forms.Timer(components);
            Dialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            Button_Create = new Guna.UI2.WinForms.Guna2Button();
            Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            TableLayoutPanel_Action = new TableLayoutPanel();
            TableLayoutPanel_Header = new TableLayoutPanel();
            DataGridView_Listing = new Guna.UI2.WinForms.Guna2DataGridView();
            Edit = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            TableLayoutPanel_Action.SuspendLayout();
            TableLayoutPanel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).BeginInit();
            SuspendLayout();
            // 
            // Timer_Debounce
            // 
            Timer_Debounce.Interval = 600;
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
            // Button_Create
            // 
            Button_Create.AllowDrop = true;
            Button_Create.Anchor = AnchorStyles.Right;
            Button_Create.AnimatedGIF = true;
            Button_Create.BorderRadius = 8;
            Button_Create.CustomizableEdges = customizableEdges1;
            Button_Create.DisabledState.BorderColor = Color.DarkGray;
            Button_Create.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Create.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Create.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Create.FillColor = Color.FromArgb(100, 88, 255);
            Button_Create.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Create.ForeColor = Color.White;
            Button_Create.Location = new Point(297, 5);
            Button_Create.Margin = new Padding(0);
            Button_Create.Name = "Button_Create";
            Button_Create.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_Create.Size = new Size(90, 40);
            Button_Create.TabIndex = 0;
            Button_Create.Text = "Thêm mới";
            Button_Create.Click += Button_Create_Click;
            // 
            // Button_Refresh
            // 
            Button_Refresh.AllowDrop = true;
            Button_Refresh.Anchor = AnchorStyles.Right;
            Button_Refresh.AnimatedGIF = true;
            Button_Refresh.BorderRadius = 8;
            Button_Refresh.CustomizableEdges = customizableEdges3;
            Button_Refresh.DisabledState.BorderColor = Color.DarkGray;
            Button_Refresh.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Refresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Refresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Refresh.FillColor = Color.Green;
            Button_Refresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Refresh.ForeColor = Color.White;
            Button_Refresh.Location = new Point(197, 5);
            Button_Refresh.Margin = new Padding(0);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Refresh.Size = new Size(90, 40);
            Button_Refresh.TabIndex = 1;
            Button_Refresh.Text = "Làm mới";
            Button_Refresh.Click += Button_Refresh_Click;
            // 
            // TableLayoutPanel_Action
            // 
            TableLayoutPanel_Action.ColumnCount = 3;
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TableLayoutPanel_Action.Controls.Add(Button_Create, 2, 0);
            TableLayoutPanel_Action.Controls.Add(Button_Refresh, 1, 0);
            TableLayoutPanel_Action.Dock = DockStyle.Fill;
            TableLayoutPanel_Action.Location = new Point(387, 0);
            TableLayoutPanel_Action.Margin = new Padding(0);
            TableLayoutPanel_Action.Name = "TableLayoutPanel_Action";
            TableLayoutPanel_Action.RowCount = 1;
            TableLayoutPanel_Action.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Action.Size = new Size(387, 50);
            TableLayoutPanel_Action.TabIndex = 1;
            // 
            // TableLayoutPanel_Header
            // 
            TableLayoutPanel_Header.ColumnCount = 2;
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.Controls.Add(TableLayoutPanel_Action, 1, 0);
            TableLayoutPanel_Header.Dock = DockStyle.Top;
            TableLayoutPanel_Header.Location = new Point(0, 0);
            TableLayoutPanel_Header.Margin = new Padding(0);
            TableLayoutPanel_Header.Name = "TableLayoutPanel_Header";
            TableLayoutPanel_Header.RowCount = 1;
            TableLayoutPanel_Header.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.Size = new Size(774, 50);
            TableLayoutPanel_Header.TabIndex = 3;
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
            DataGridView_Listing.Columns.AddRange(new DataGridViewColumn[] { Edit, Id, UserName, Password });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DataGridView_Listing.DefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_Listing.Dock = DockStyle.Fill;
            DataGridView_Listing.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.Location = new Point(0, 50);
            DataGridView_Listing.Margin = new Padding(0);
            DataGridView_Listing.Name = "DataGridView_Listing";
            DataGridView_Listing.ReadOnly = true;
            DataGridView_Listing.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridView_Listing.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridView_Listing.RowHeadersVisible = false;
            DataGridView_Listing.RowHeadersWidth = 51;
            DataGridView_Listing.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.RowTemplate.Height = 40;
            DataGridView_Listing.Size = new Size(774, 474);
            DataGridView_Listing.TabIndex = 6;
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
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Edit.HeaderText = "";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 40;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Id.DefaultCellStyle = dataGridViewCellStyle3;
            Id.DividerWidth = 1;
            Id.HeaderText = "Mã người dùng";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 130;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            UserName.DataPropertyName = "UserName";
            UserName.DividerWidth = 1;
            UserName.HeaderText = "Tên người dùng";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 200;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "Password";
            Password.DividerWidth = 1;
            Password.HeaderText = "Mật khẩu";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // UserAssignRoleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DataGridView_Listing);
            Controls.Add(TableLayoutPanel_Header);
            Name = "UserAssignRoleControl";
            Size = new Size(774, 524);
            TableLayoutPanel_Action.ResumeLayout(false);
            TableLayoutPanel_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer Timer_Debounce;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Confirm;
        private Guna.UI2.WinForms.Guna2Button Button_Create;
        private Guna.UI2.WinForms.Guna2Button Button_Refresh;
        private TableLayoutPanel TableLayoutPanel_Action;
        private TableLayoutPanel TableLayoutPanel_Header;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Listing;
        private DataGridViewButtonColumn Edit;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
    }
}
