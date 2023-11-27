namespace WinFormsApp.Resources.Controls.Module.Order
{
    partial class OrderControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridView_Listing = new Guna.UI2.WinForms.Guna2DataGridView();
            see = new DataGridViewButtonColumn();
            InternalCode = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            TableLayoutPanel_Header = new TableLayoutPanel();
            Text_Search = new Guna.UI2.WinForms.Guna2TextBox();
            TableLayoutPanel_Action = new TableLayoutPanel();
            Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            Dialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            Timer_Debounce = new System.Windows.Forms.Timer(components);
            TableLayoutPanel_Paginator = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).BeginInit();
            TableLayoutPanel_Header.SuspendLayout();
            TableLayoutPanel_Action.SuspendLayout();
            SuspendLayout();
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
            DataGridView_Listing.Columns.AddRange(new DataGridViewColumn[] { see, InternalCode, Employee, Customer, PhoneNumber, OrderDate, Price, Type, Id });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DataGridView_Listing.DefaultCellStyle = dataGridViewCellStyle9;
            DataGridView_Listing.Dock = DockStyle.Fill;
            DataGridView_Listing.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.Location = new Point(0, 50);
            DataGridView_Listing.Margin = new Padding(0);
            DataGridView_Listing.Name = "DataGridView_Listing";
            DataGridView_Listing.ReadOnly = true;
            DataGridView_Listing.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DataGridView_Listing.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DataGridView_Listing.RowHeadersVisible = false;
            DataGridView_Listing.RowHeadersWidth = 51;
            DataGridView_Listing.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.RowTemplate.Height = 40;
            DataGridView_Listing.Size = new Size(996, 597);
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
            // see
            // 
            see.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            see.DefaultCellStyle = dataGridViewCellStyle3;
            see.FillWeight = 20F;
            see.Frozen = true;
            see.HeaderText = "";
            see.MinimumWidth = 6;
            see.Name = "see";
            see.ReadOnly = true;
            see.Text = "Xem";
            see.UseColumnTextForButtonValue = true;
            see.Width = 6;
            // 
            // InternalCode
            // 
            InternalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InternalCode.DataPropertyName = "InternalCode";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            InternalCode.DefaultCellStyle = dataGridViewCellStyle4;
            InternalCode.DividerWidth = 1;
            InternalCode.FillWeight = 41.4820366F;
            InternalCode.HeaderText = "Mã đơn hàng";
            InternalCode.MinimumWidth = 6;
            InternalCode.Name = "InternalCode";
            InternalCode.ReadOnly = true;
            InternalCode.Resizable = DataGridViewTriState.True;
            InternalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Employee
            // 
            Employee.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Employee.DefaultCellStyle = dataGridViewCellStyle5;
            Employee.DividerWidth = 1;
            Employee.HeaderText = "Nhân viên";
            Employee.Name = "Employee";
            Employee.ReadOnly = true;
            Employee.Width = 220;
            // 
            // Customer
            // 
            Customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Customer.DividerWidth = 1;
            Customer.HeaderText = "Khách hàng";
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            Customer.Width = 220;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PhoneNumber.DefaultCellStyle = dataGridViewCellStyle6;
            PhoneNumber.DividerWidth = 1;
            PhoneNumber.HeaderText = "Số điện thoại";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 120;
            // 
            // OrderDate
            // 
            OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            OrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            OrderDate.DefaultCellStyle = dataGridViewCellStyle7;
            OrderDate.DividerWidth = 1;
            OrderDate.FillWeight = 41.4820366F;
            OrderDate.HeaderText = "Ngày đặt";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 150;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "{0,0}";
            Price.DefaultCellStyle = dataGridViewCellStyle8;
            Price.DividerWidth = 1;
            Price.HeaderText = "Tổng tiền";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 120;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Type.HeaderText = "Trạng thái";
            Type.MinimumWidth = 120;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 125;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // TableLayoutPanel_Header
            // 
            TableLayoutPanel_Header.ColumnCount = 2;
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.13654F));
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.8634539F));
            TableLayoutPanel_Header.Controls.Add(Text_Search, 0, 0);
            TableLayoutPanel_Header.Controls.Add(TableLayoutPanel_Action, 1, 0);
            TableLayoutPanel_Header.Dock = DockStyle.Top;
            TableLayoutPanel_Header.Location = new Point(0, 0);
            TableLayoutPanel_Header.Margin = new Padding(0);
            TableLayoutPanel_Header.Name = "TableLayoutPanel_Header";
            TableLayoutPanel_Header.RowCount = 1;
            TableLayoutPanel_Header.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.Size = new Size(996, 50);
            TableLayoutPanel_Header.TabIndex = 4;
            // 
            // Text_Search
            // 
            Text_Search.Anchor = AnchorStyles.Left;
            Text_Search.Animated = true;
            Text_Search.BorderRadius = 8;
            Text_Search.CustomizableEdges = customizableEdges1;
            Text_Search.DefaultText = "";
            Text_Search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Text_Search.ForeColor = Color.Black;
            Text_Search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Location = new Point(0, 5);
            Text_Search.Margin = new Padding(0);
            Text_Search.Name = "Text_Search";
            Text_Search.PasswordChar = '\0';
            Text_Search.PlaceholderText = "Tìm kiếm...";
            Text_Search.SelectedText = "";
            Text_Search.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_Search.Size = new Size(234, 40);
            Text_Search.TabIndex = 2;
            Text_Search.TextChanged += Text_Search_TextChanged;
            // 
            // TableLayoutPanel_Action
            // 
            TableLayoutPanel_Action.ColumnCount = 1;
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Action.Controls.Add(Button_Refresh, 0, 0);
            TableLayoutPanel_Action.Dock = DockStyle.Fill;
            TableLayoutPanel_Action.Location = new Point(838, 0);
            TableLayoutPanel_Action.Margin = new Padding(0);
            TableLayoutPanel_Action.Name = "TableLayoutPanel_Action";
            TableLayoutPanel_Action.RowCount = 1;
            TableLayoutPanel_Action.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Action.Size = new Size(158, 50);
            TableLayoutPanel_Action.TabIndex = 1;
            // 
            // Button_Refresh
            // 
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
            Button_Refresh.Location = new Point(68, 5);
            Button_Refresh.Margin = new Padding(0);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Refresh.Size = new Size(90, 40);
            Button_Refresh.TabIndex = 1;
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
            Timer_Debounce.Tick += Timer_Debounce_Tick;
            // 
            // TableLayoutPanel_Paginator
            // 
            TableLayoutPanel_Paginator.ColumnCount = 1;
            TableLayoutPanel_Paginator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Paginator.Dock = DockStyle.Bottom;
            TableLayoutPanel_Paginator.Location = new Point(0, 647);
            TableLayoutPanel_Paginator.Name = "TableLayoutPanel_Paginator";
            TableLayoutPanel_Paginator.RowCount = 1;
            TableLayoutPanel_Paginator.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Paginator.Size = new Size(996, 50);
            TableLayoutPanel_Paginator.TabIndex = 5;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DataGridView_Listing);
            Controls.Add(TableLayoutPanel_Header);
            Controls.Add(TableLayoutPanel_Paginator);
            Name = "OrderControl";
            Size = new Size(996, 697);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).EndInit();
            TableLayoutPanel_Header.ResumeLayout(false);
            TableLayoutPanel_Action.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Listing;
        private TableLayoutPanel TableLayoutPanel_Header;
        private Guna.UI2.WinForms.Guna2TextBox Text_Search;
        private TableLayoutPanel TableLayoutPanel_Action;
        private Guna.UI2.WinForms.Guna2Button Button_Refresh;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Confirm;
        private System.Windows.Forms.Timer Timer_Debounce;
        private TableLayoutPanel TableLayoutPanel_Paginator;
        private DataGridViewButtonColumn see;
        private DataGridViewTextBoxColumn InternalCode;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Id;
    }
}
