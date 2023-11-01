﻿namespace WinFormsApp.Resources.Controls.Module.Product
{
    partial class ProductControl
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Timer_Debounce = new System.Windows.Forms.Timer(components);
            FlowLayoutPanel_Paginator = new FlowLayoutPanel();
            Dialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            DataGridView_Listing = new Guna.UI2.WinForms.Guna2DataGridView();
            Button_Create = new Guna.UI2.WinForms.Guna2Button();
            Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            Text_Search = new Guna.UI2.WinForms.Guna2TextBox();
            TableLayoutPanel_Action = new TableLayoutPanel();
            TableLayoutPanel_Header = new TableLayoutPanel();
            TableLayoutPanel_Container = new TableLayoutPanel();
            edit = new DataGridViewButtonColumn();
            remove = new DataGridViewButtonColumn();
            InternalCode = new DataGridViewTextBoxColumn();
            _Name = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            ColorName = new DataGridViewTextBoxColumn();
            CapacityName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            CapacityId = new DataGridViewTextBoxColumn();
            ColorId = new DataGridViewTextBoxColumn();
            ColorInternalCode = new DataGridViewTextBoxColumn();
            CategoryInternalCode = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).BeginInit();
            TableLayoutPanel_Action.SuspendLayout();
            TableLayoutPanel_Header.SuspendLayout();
            TableLayoutPanel_Container.SuspendLayout();
            SuspendLayout();
            // 
            // Timer_Debounce
            // 
            Timer_Debounce.Interval = 600;
            // 
            // FlowLayoutPanel_Paginator
            // 
            FlowLayoutPanel_Paginator.AutoSize = true;
            FlowLayoutPanel_Paginator.Dock = DockStyle.Right;
            FlowLayoutPanel_Paginator.Location = new Point(824, 493);
            FlowLayoutPanel_Paginator.Name = "FlowLayoutPanel_Paginator";
            FlowLayoutPanel_Paginator.Size = new Size(0, 42);
            FlowLayoutPanel_Paginator.TabIndex = 2;
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
            // DataGridView_Listing
            // 
            DataGridView_Listing.AllowUserToAddRows = false;
            DataGridView_Listing.AllowUserToDeleteRows = false;
            DataGridView_Listing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_Listing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_Listing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_Listing.ColumnHeadersHeight = 50;
            DataGridView_Listing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Listing.Columns.AddRange(new DataGridViewColumn[] { edit, remove, InternalCode, _Name, CategoryName, ColorName, CapacityName, Price, Quantity, Id, CapacityId, ColorId, ColorInternalCode, CategoryInternalCode, CategoryId });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataGridView_Listing.DefaultCellStyle = dataGridViewCellStyle5;
            DataGridView_Listing.Dock = DockStyle.Fill;
            DataGridView_Listing.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.Location = new Point(0, 55);
            DataGridView_Listing.Margin = new Padding(0);
            DataGridView_Listing.Name = "DataGridView_Listing";
            DataGridView_Listing.ReadOnly = true;
            DataGridView_Listing.RowHeadersVisible = false;
            DataGridView_Listing.RowHeadersWidth = 51;
            DataGridView_Listing.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.RowTemplate.Height = 50;
            DataGridView_Listing.Size = new Size(827, 435);
            DataGridView_Listing.TabIndex = 1;
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
            DataGridView_Listing.ThemeStyle.HeaderStyle.Height = 50;
            DataGridView_Listing.ThemeStyle.ReadOnly = true;
            DataGridView_Listing.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_Listing.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_Listing.ThemeStyle.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Listing.ThemeStyle.RowsStyle.Height = 50;
            DataGridView_Listing.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_Listing.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Listing.CellClick += DataGridView_Listing_CellClick;
            // 
            // Button_Create
            // 
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
            Button_Create.Location = new Point(323, 7);
            Button_Create.Margin = new Padding(0);
            Button_Create.Name = "Button_Create";
            Button_Create.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_Create.Size = new Size(91, 41);
            Button_Create.TabIndex = 0;
            Button_Create.Text = "Thêm mới";
            Button_Create.Click += Button_Create_Click;
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
            Button_Refresh.Location = new Point(223, 7);
            Button_Refresh.Margin = new Padding(0);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Refresh.Size = new Size(91, 41);
            Button_Refresh.TabIndex = 1;
            Button_Refresh.Text = "Làm mới";
            Button_Refresh.Click += Button_Refresh_Click;
            // 
            // Text_Search
            // 
            Text_Search.Anchor = AnchorStyles.Left;
            Text_Search.Animated = true;
            Text_Search.BorderRadius = 8;
            Text_Search.CustomizableEdges = customizableEdges5;
            Text_Search.DefaultText = "";
            Text_Search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Text_Search.ForeColor = Color.Black;
            Text_Search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Location = new Point(0, 7);
            Text_Search.Margin = new Padding(0);
            Text_Search.Name = "Text_Search";
            Text_Search.PasswordChar = '\0';
            Text_Search.PlaceholderText = "Tìm kiếm...";
            Text_Search.SelectedText = "";
            Text_Search.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Text_Search.Size = new Size(234, 41);
            Text_Search.TabIndex = 2;
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
            TableLayoutPanel_Action.Location = new Point(413, 0);
            TableLayoutPanel_Action.Margin = new Padding(0);
            TableLayoutPanel_Action.Name = "TableLayoutPanel_Action";
            TableLayoutPanel_Action.RowCount = 1;
            TableLayoutPanel_Action.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Action.Size = new Size(414, 55);
            TableLayoutPanel_Action.TabIndex = 1;
            // 
            // TableLayoutPanel_Header
            // 
            TableLayoutPanel_Header.ColumnCount = 2;
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.Controls.Add(Text_Search, 0, 0);
            TableLayoutPanel_Header.Controls.Add(TableLayoutPanel_Action, 1, 0);
            TableLayoutPanel_Header.Dock = DockStyle.Fill;
            TableLayoutPanel_Header.Location = new Point(0, 0);
            TableLayoutPanel_Header.Margin = new Padding(0);
            TableLayoutPanel_Header.Name = "TableLayoutPanel_Header";
            TableLayoutPanel_Header.RowCount = 1;
            TableLayoutPanel_Header.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.Size = new Size(827, 55);
            TableLayoutPanel_Header.TabIndex = 0;
            // 
            // TableLayoutPanel_Container
            // 
            TableLayoutPanel_Container.ColumnCount = 1;
            TableLayoutPanel_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Container.Controls.Add(TableLayoutPanel_Header, 0, 0);
            TableLayoutPanel_Container.Controls.Add(DataGridView_Listing, 0, 1);
            TableLayoutPanel_Container.Controls.Add(FlowLayoutPanel_Paginator, 0, 2);
            TableLayoutPanel_Container.Dock = DockStyle.Fill;
            TableLayoutPanel_Container.Location = new Point(0, 0);
            TableLayoutPanel_Container.Margin = new Padding(0);
            TableLayoutPanel_Container.Name = "TableLayoutPanel_Container";
            TableLayoutPanel_Container.RowCount = 3;
            TableLayoutPanel_Container.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            TableLayoutPanel_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Container.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            TableLayoutPanel_Container.Size = new Size(827, 538);
            TableLayoutPanel_Container.TabIndex = 1;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 88, 255);
            edit.DefaultCellStyle = dataGridViewCellStyle3;
            edit.FillWeight = 20F;
            edit.HeaderText = "";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Sửa";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 6;
            // 
            // remove
            // 
            remove.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            remove.DefaultCellStyle = dataGridViewCellStyle4;
            remove.FillWeight = 20F;
            remove.HeaderText = "";
            remove.MinimumWidth = 6;
            remove.Name = "remove";
            remove.ReadOnly = true;
            remove.Text = "Xóa";
            remove.UseColumnTextForButtonValue = true;
            remove.Width = 6;
            // 
            // InternalCode
            // 
            InternalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InternalCode.DataPropertyName = "InternalCode";
            InternalCode.FillWeight = 41.4820366F;
            InternalCode.HeaderText = "Mã sản phẩm";
            InternalCode.MinimumWidth = 6;
            InternalCode.Name = "InternalCode";
            InternalCode.ReadOnly = true;
            InternalCode.Resizable = DataGridViewTriState.True;
            InternalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // _Name
            // 
            _Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _Name.DataPropertyName = "Name";
            _Name.FillWeight = 41.4820366F;
            _Name.HeaderText = "Tên sản phẩm";
            _Name.MinimumWidth = 6;
            _Name.Name = "_Name";
            _Name.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Danh mục";
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // ColorName
            // 
            ColorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColorName.DataPropertyName = "ColorName";
            ColorName.HeaderText = "Màu";
            ColorName.Name = "ColorName";
            ColorName.ReadOnly = true;
            // 
            // CapacityName
            // 
            CapacityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CapacityName.DataPropertyName = "CapacityName";
            CapacityName.HeaderText = "Dung lượng";
            CapacityName.Name = "CapacityName";
            CapacityName.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.FillWeight = 41.4820366F;
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.DataPropertyName = "Quantity";
            Quantity.FillWeight = 41.4820366F;
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
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
            // CapacityId
            // 
            CapacityId.DataPropertyName = "CapacityId";
            CapacityId.HeaderText = "CapacityId";
            CapacityId.Name = "CapacityId";
            CapacityId.ReadOnly = true;
            CapacityId.Visible = false;
            // 
            // ColorId
            // 
            ColorId.DataPropertyName = "ColorId";
            ColorId.HeaderText = "ColorId";
            ColorId.Name = "ColorId";
            ColorId.ReadOnly = true;
            ColorId.Visible = false;
            // 
            // ColorInternalCode
            // 
            ColorInternalCode.DataPropertyName = "ColorInternalCode";
            ColorInternalCode.HeaderText = "ColorInternalCode";
            ColorInternalCode.Name = "ColorInternalCode";
            ColorInternalCode.ReadOnly = true;
            ColorInternalCode.Visible = false;
            // 
            // CategoryInternalCode
            // 
            CategoryInternalCode.DataPropertyName = "CategoryInternalCode";
            CategoryInternalCode.HeaderText = "CategoryInternalCode";
            CategoryInternalCode.Name = "CategoryInternalCode";
            CategoryInternalCode.ReadOnly = true;
            CategoryInternalCode.Visible = false;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.Name = "CategoryId";
            CategoryId.ReadOnly = true;
            CategoryId.Visible = false;
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel_Container);
            Name = "ProductControl";
            Size = new Size(827, 538);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).EndInit();
            TableLayoutPanel_Action.ResumeLayout(false);
            TableLayoutPanel_Header.ResumeLayout(false);
            TableLayoutPanel_Container.ResumeLayout(false);
            TableLayoutPanel_Container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer_Debounce;
        private FlowLayoutPanel FlowLayoutPanel_Paginator;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Confirm;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Listing;
        private Guna.UI2.WinForms.Guna2Button Button_Create;
        private Guna.UI2.WinForms.Guna2Button Button_Refresh;
        private Guna.UI2.WinForms.Guna2TextBox Text_Search;
        private TableLayoutPanel TableLayoutPanel_Action;
        private TableLayoutPanel TableLayoutPanel_Header;
        private TableLayoutPanel TableLayoutPanel_Container;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn remove;
        private DataGridViewTextBoxColumn InternalCode;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn ColorName;
        private DataGridViewTextBoxColumn CapacityName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CapacityId;
        private DataGridViewTextBoxColumn ColorId;
        private DataGridViewTextBoxColumn ColorInternalCode;
        private DataGridViewTextBoxColumn CategoryInternalCode;
        private DataGridViewTextBoxColumn CategoryId;
    }
}