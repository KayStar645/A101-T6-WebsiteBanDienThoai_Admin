namespace WinFormsApp.Resources.Controls.Module.Distributor
{
    partial class DistributorControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TableLayoutPanel_Container = new TableLayoutPanel();
            TableLayoutPanel_Header = new TableLayoutPanel();
            Text_Search = new Guna.UI2.WinForms.Guna2TextBox();
            TableLayoutPanel_Action = new TableLayoutPanel();
            Button_Create = new Guna.UI2.WinForms.Guna2Button();
            DataGridView_Listing = new Guna.UI2.WinForms.Guna2DataGridView();
            edit = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            remove = new DataGridViewButtonColumn();
            internal_code = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            is_deleted = new DataGridViewCheckBoxColumn();
            TableLayoutPanel_Container.SuspendLayout();
            TableLayoutPanel_Header.SuspendLayout();
            TableLayoutPanel_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel_Container
            // 
            TableLayoutPanel_Container.ColumnCount = 1;
            TableLayoutPanel_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Container.Controls.Add(TableLayoutPanel_Header, 0, 0);
            TableLayoutPanel_Container.Controls.Add(DataGridView_Listing, 0, 1);
            TableLayoutPanel_Container.Dock = DockStyle.Fill;
            TableLayoutPanel_Container.Location = new Point(0, 0);
            TableLayoutPanel_Container.Margin = new Padding(0);
            TableLayoutPanel_Container.Name = "TableLayoutPanel_Container";
            TableLayoutPanel_Container.RowCount = 2;
            TableLayoutPanel_Container.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            TableLayoutPanel_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Container.Size = new Size(1040, 827);
            TableLayoutPanel_Container.TabIndex = 0;
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
            TableLayoutPanel_Header.Size = new Size(1040, 73);
            TableLayoutPanel_Header.TabIndex = 0;
            // 
            // Text_Search
            // 
            Text_Search.Animated = true;
            Text_Search.BorderRadius = 8;
            Text_Search.CustomizableEdges = customizableEdges1;
            Text_Search.DefaultText = "";
            Text_Search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Location = new Point(0, 0);
            Text_Search.Margin = new Padding(0);
            Text_Search.Name = "Text_Search";
            Text_Search.PasswordChar = '\0';
            Text_Search.PlaceholderText = "Tìm kiếm...";
            Text_Search.SelectedText = "";
            Text_Search.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_Search.Size = new Size(267, 55);
            Text_Search.TabIndex = 2;
            // 
            // TableLayoutPanel_Action
            // 
            TableLayoutPanel_Action.ColumnCount = 2;
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Action.Controls.Add(Button_Create, 1, 0);
            TableLayoutPanel_Action.Dock = DockStyle.Fill;
            TableLayoutPanel_Action.Location = new Point(520, 0);
            TableLayoutPanel_Action.Margin = new Padding(0);
            TableLayoutPanel_Action.Name = "TableLayoutPanel_Action";
            TableLayoutPanel_Action.RowCount = 1;
            TableLayoutPanel_Action.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Action.Size = new Size(520, 73);
            TableLayoutPanel_Action.TabIndex = 1;
            // 
            // Button_Create
            // 
            Button_Create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button_Create.AnimatedGIF = true;
            Button_Create.BorderRadius = 8;
            Button_Create.CustomizableEdges = customizableEdges3;
            Button_Create.DisabledState.BorderColor = Color.DarkGray;
            Button_Create.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Create.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Create.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Create.FillColor = Color.FromArgb(100, 88, 255);
            Button_Create.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Create.ForeColor = Color.White;
            Button_Create.Location = new Point(416, 0);
            Button_Create.Margin = new Padding(0);
            Button_Create.Name = "Button_Create";
            Button_Create.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Create.Size = new Size(104, 55);
            Button_Create.TabIndex = 0;
            Button_Create.Text = "Thêm mới";
            Button_Create.Click += Button_Create_Click;
            // 
            // DataGridView_Listing
            // 
            DataGridView_Listing.AllowUserToAddRows = false;
            DataGridView_Listing.AllowUserToDeleteRows = false;
            DataGridView_Listing.AllowUserToOrderColumns = true;
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
            DataGridView_Listing.Columns.AddRange(new DataGridViewColumn[] { edit, Id, remove, internal_code, name, address, phone_number, is_deleted });
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
            DataGridView_Listing.Location = new Point(0, 73);
            DataGridView_Listing.Margin = new Padding(0);
            DataGridView_Listing.Name = "DataGridView_Listing";
            DataGridView_Listing.ReadOnly = true;
            DataGridView_Listing.RowHeadersVisible = false;
            DataGridView_Listing.RowHeadersWidth = 51;
            DataGridView_Listing.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Listing.RowTemplate.Height = 50;
            DataGridView_Listing.Size = new Size(1040, 754);
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
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
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
            // internal_code
            // 
            internal_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            internal_code.DataPropertyName = "InternalCode";
            internal_code.FillWeight = 41.4820366F;
            internal_code.HeaderText = "Mã nhà cung cấp";
            internal_code.MinimumWidth = 6;
            internal_code.Name = "internal_code";
            internal_code.ReadOnly = true;
            internal_code.Resizable = DataGridViewTriState.True;
            internal_code.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.DataPropertyName = "Name";
            name.FillWeight = 41.4820366F;
            name.HeaderText = "Tên nhà cung cấp";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.DataPropertyName = "Address";
            address.FillWeight = 41.4820366F;
            address.HeaderText = "Địa chỉ";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // phone_number
            // 
            phone_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone_number.DataPropertyName = "Phone";
            phone_number.FillWeight = 41.4820366F;
            phone_number.HeaderText = "Số điện thoại";
            phone_number.MinimumWidth = 6;
            phone_number.Name = "phone_number";
            phone_number.ReadOnly = true;
            // 
            // is_deleted
            // 
            is_deleted.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            is_deleted.DataPropertyName = "IsDeleted";
            is_deleted.FalseValue = "0";
            is_deleted.FillWeight = 41.4820366F;
            is_deleted.HeaderText = "Trạng thái";
            is_deleted.MinimumWidth = 6;
            is_deleted.Name = "is_deleted";
            is_deleted.ReadOnly = true;
            is_deleted.Resizable = DataGridViewTriState.True;
            is_deleted.SortMode = DataGridViewColumnSortMode.Automatic;
            is_deleted.TrueValue = "1";
            is_deleted.Visible = false;
            // 
            // DistributorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel_Container);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DistributorControl";
            Size = new Size(1040, 827);
            TableLayoutPanel_Container.ResumeLayout(false);
            TableLayoutPanel_Header.ResumeLayout(false);
            TableLayoutPanel_Action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Listing).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_Container;
        private TableLayoutPanel TableLayoutPanel_Header;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Listing;
        private TableLayoutPanel TableLayoutPanel_Action;
        private Guna.UI2.WinForms.Guna2Button Button_Create;
        private Guna.UI2.WinForms.Guna2TextBox Text_Search;
        private DataGridViewButtonColumn edit;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewButtonColumn remove;
        private DataGridViewTextBoxColumn internal_code;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewCheckBoxColumn is_deleted;
    }
}
