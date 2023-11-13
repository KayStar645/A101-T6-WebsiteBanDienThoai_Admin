namespace WinFormsApp.Resources.Controls.Module.Order
{
    partial class OrderProductControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            Button_Save = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            TableLayoutPanel_Paginator = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Btn_AddNewProduct = new Guna.UI2.WinForms.Guna2Button();
            Text_Search = new Guna.UI2.WinForms.Guna2TextBox();
            DataGridView_Product = new Guna.UI2.WinForms.Guna2DataGridView();
            Timer_Debounce = new System.Windows.Forms.Timer(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ProductSelect = new DataGridViewCheckBoxColumn();
            InternalCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ColorName = new DataGridViewTextBoxColumn();
            CapacityName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            CapacityId = new DataGridViewTextBoxColumn();
            ColorId = new DataGridViewTextBoxColumn();
            ColorInternalCode = new DataGridViewTextBoxColumn();
            CategoryInternalCode = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Product).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 8);
            label1.Name = "label1";
            label1.Size = new Size(138, 19);
            label1.TabIndex = 10;
            label1.Text = "Danh sách sản phẩm";
            // 
            // Button_Cancel
            // 
            Button_Cancel.Anchor = AnchorStyles.Left;
            Button_Cancel.Animated = true;
            Button_Cancel.AnimatedGIF = true;
            Button_Cancel.BorderRadius = 8;
            Button_Cancel.CustomizableEdges = customizableEdges1;
            Button_Cancel.DisabledState.BorderColor = Color.DarkGray;
            Button_Cancel.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Cancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Cancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Cancel.FillColor = Color.DarkGray;
            Button_Cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Cancel.ForeColor = Color.White;
            Button_Cancel.Location = new Point(11, 5);
            Button_Cancel.Margin = new Padding(3, 2, 3, 2);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_Cancel.Size = new Size(70, 40);
            Button_Cancel.TabIndex = 2;
            Button_Cancel.Text = "Hủy";
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Save
            // 
            Button_Save.Anchor = AnchorStyles.Right;
            Button_Save.Animated = true;
            Button_Save.AnimatedGIF = true;
            Button_Save.BorderRadius = 8;
            Button_Save.CustomizableEdges = customizableEdges3;
            Button_Save.DisabledState.BorderColor = Color.DarkGray;
            Button_Save.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Save.FillColor = Color.FromArgb(100, 88, 255);
            Button_Save.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Save.ForeColor = Color.White;
            Button_Save.Location = new Point(719, 5);
            Button_Save.Margin = new Padding(3, 2, 3, 2);
            Button_Save.Name = "Button_Save";
            Button_Save.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Save.Size = new Size(70, 40);
            Button_Save.TabIndex = 1;
            Button_Save.Text = "Lưu";
            Button_Save.Click += Button_Save_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(800, 35);
            tableLayoutPanel5.TabIndex = 25;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = SystemColors.Control;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(Button_Cancel, 0, 0);
            tableLayoutPanel6.Controls.Add(Button_Save, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Bottom;
            tableLayoutPanel6.Location = new Point(0, 580);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(8, 0, 8, 0);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(800, 50);
            tableLayoutPanel6.TabIndex = 23;
            // 
            // TableLayoutPanel_Paginator
            // 
            TableLayoutPanel_Paginator.BackColor = Color.White;
            TableLayoutPanel_Paginator.ColumnCount = 1;
            TableLayoutPanel_Paginator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Paginator.Dock = DockStyle.Bottom;
            TableLayoutPanel_Paginator.Location = new Point(0, 530);
            TableLayoutPanel_Paginator.Name = "TableLayoutPanel_Paginator";
            TableLayoutPanel_Paginator.RowCount = 1;
            TableLayoutPanel_Paginator.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Paginator.Size = new Size(800, 50);
            TableLayoutPanel_Paginator.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 161F));
            tableLayoutPanel2.Controls.Add(Btn_AddNewProduct, 0, 0);
            tableLayoutPanel2.Controls.Add(Text_Search, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(800, 50);
            tableLayoutPanel2.TabIndex = 28;
            // 
            // Btn_AddNewProduct
            // 
            Btn_AddNewProduct.Anchor = AnchorStyles.Right;
            Btn_AddNewProduct.Animated = true;
            Btn_AddNewProduct.AnimatedGIF = true;
            Btn_AddNewProduct.BorderRadius = 8;
            Btn_AddNewProduct.CustomizableEdges = customizableEdges5;
            Btn_AddNewProduct.DisabledState.BorderColor = Color.DarkGray;
            Btn_AddNewProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn_AddNewProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn_AddNewProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn_AddNewProduct.FillColor = Color.FromArgb(100, 88, 255);
            Btn_AddNewProduct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_AddNewProduct.ForeColor = Color.White;
            Btn_AddNewProduct.Location = new Point(648, 5);
            Btn_AddNewProduct.Margin = new Padding(3, 2, 3, 2);
            Btn_AddNewProduct.Name = "Btn_AddNewProduct";
            Btn_AddNewProduct.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Btn_AddNewProduct.Size = new Size(149, 40);
            Btn_AddNewProduct.TabIndex = 2;
            Btn_AddNewProduct.Text = "Thêm mới sản phẩm";
            Btn_AddNewProduct.Click += Btn_AddNewProduct_Click;
            // 
            // Text_Search
            // 
            Text_Search.Anchor = AnchorStyles.Left;
            Text_Search.BorderRadius = 5;
            Text_Search.CustomizableEdges = customizableEdges7;
            Text_Search.DefaultText = "";
            Text_Search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Search.ForeColor = Color.Black;
            Text_Search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Location = new Point(3, 7);
            Text_Search.Name = "Text_Search";
            Text_Search.PasswordChar = '\0';
            Text_Search.PlaceholderText = "Tìm kiếm";
            Text_Search.SelectedText = "";
            Text_Search.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Text_Search.Size = new Size(278, 36);
            Text_Search.TabIndex = 0;
            Text_Search.TextChanged += Text_Search_TextChanged;
            // 
            // DataGridView_Product
            // 
            DataGridView_Product.AllowUserToAddRows = false;
            DataGridView_Product.AllowUserToDeleteRows = false;
            DataGridView_Product.AllowUserToResizeColumns = false;
            DataGridView_Product.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridView_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_Product.ColumnHeadersHeight = 40;
            DataGridView_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Product.Columns.AddRange(new DataGridViewColumn[] { ProductSelect, InternalCode, ProductName, ColorName, CapacityName, Price, Quantity, Id, CategoryName, CapacityId, ColorId, ColorInternalCode, CategoryInternalCode, CategoryId });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataGridView_Product.DefaultCellStyle = dataGridViewCellStyle5;
            DataGridView_Product.Dock = DockStyle.Fill;
            DataGridView_Product.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Product.Location = new Point(0, 85);
            DataGridView_Product.Margin = new Padding(0);
            DataGridView_Product.MultiSelect = false;
            DataGridView_Product.Name = "DataGridView_Product";
            DataGridView_Product.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DataGridView_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DataGridView_Product.RowHeadersVisible = false;
            DataGridView_Product.RowHeadersWidth = 51;
            DataGridView_Product.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Product.RowTemplate.Height = 40;
            DataGridView_Product.Size = new Size(800, 445);
            DataGridView_Product.TabIndex = 29;
            DataGridView_Product.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_Product.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_Product.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_Product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_Product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_Product.ThemeStyle.BackColor = Color.White;
            DataGridView_Product.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Product.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_Product.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_Product.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridView_Product.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_Product.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Product.ThemeStyle.HeaderStyle.Height = 40;
            DataGridView_Product.ThemeStyle.ReadOnly = false;
            DataGridView_Product.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_Product.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_Product.ThemeStyle.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Product.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Product.ThemeStyle.RowsStyle.Height = 40;
            DataGridView_Product.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_Product.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Product.CellClick += DataGridView_Product_CellClick;
            DataGridView_Product.CellEndEdit += DataGridView_Product_CellEndEdit;
            // 
            // Timer_Debounce
            // 
            Timer_Debounce.Interval = 600;
            Timer_Debounce.Tick += Timer_Debounce_Tick;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 12;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ProductSelect
            // 
            ProductSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ProductSelect.FalseValue = "False";
            ProductSelect.HeaderText = "";
            ProductSelect.Name = "ProductSelect";
            ProductSelect.TrueValue = "True";
            ProductSelect.Width = 40;
            // 
            // InternalCode
            // 
            InternalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            InternalCode.DataPropertyName = "InternalCode";
            InternalCode.DividerWidth = 1;
            InternalCode.FillWeight = 0.316279262F;
            InternalCode.HeaderText = "Mã sản phẩm";
            InternalCode.MinimumWidth = 6;
            InternalCode.Name = "InternalCode";
            InternalCode.ReadOnly = true;
            InternalCode.Resizable = DataGridViewTriState.True;
            InternalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            InternalCode.Width = 120;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "Name";
            ProductName.DividerWidth = 1;
            ProductName.FillWeight = 0.316279262F;
            ProductName.HeaderText = "Tên sản phẩm";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // ColorName
            // 
            ColorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColorName.DataPropertyName = "ColorName";
            ColorName.DividerWidth = 1;
            ColorName.FillWeight = 163.152664F;
            ColorName.HeaderText = "Màu";
            ColorName.Name = "ColorName";
            ColorName.ReadOnly = true;
            // 
            // CapacityName
            // 
            CapacityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CapacityName.DataPropertyName = "CapacityName";
            CapacityName.DividerWidth = 1;
            CapacityName.FillWeight = 52.65846F;
            CapacityName.HeaderText = "Dung lượng";
            CapacityName.MinimumWidth = 40;
            CapacityName.Name = "CapacityName";
            CapacityName.ReadOnly = true;
            CapacityName.Width = 120;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "0,0";
            Price.DefaultCellStyle = dataGridViewCellStyle3;
            Price.DividerWidth = 1;
            Price.FillWeight = 149.168167F;
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            Quantity.DividerWidth = 1;
            Quantity.FillWeight = 0.316279262F;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Visible = false;
            Quantity.Width = 120;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.DividerWidth = 8;
            CategoryName.HeaderText = "CategoryName";
            CategoryName.Name = "CategoryName";
            CategoryName.Visible = false;
            // 
            // CapacityId
            // 
            CapacityId.DataPropertyName = "CapacityId";
            CapacityId.HeaderText = "CapacityId";
            CapacityId.Name = "CapacityId";
            CapacityId.Visible = false;
            // 
            // ColorId
            // 
            ColorId.DataPropertyName = "ColorId";
            ColorId.HeaderText = "ColorId";
            ColorId.Name = "ColorId";
            ColorId.Visible = false;
            // 
            // ColorInternalCode
            // 
            ColorInternalCode.DataPropertyName = "ColorInternalCode";
            ColorInternalCode.HeaderText = "ColorInternalCode";
            ColorInternalCode.Name = "ColorInternalCode";
            ColorInternalCode.Visible = false;
            // 
            // CategoryInternalCode
            // 
            CategoryInternalCode.DataPropertyName = "CategoryInternalCode";
            CategoryInternalCode.HeaderText = "CategoryInternalCode";
            CategoryInternalCode.Name = "CategoryInternalCode";
            CategoryInternalCode.Visible = false;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.Name = "CategoryId";
            CategoryId.Visible = false;
            // 
            // OrderProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 630);
            Controls.Add(DataGridView_Product);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(TableLayoutPanel_Paginator);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderProductControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderProductControl";
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Product).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private Guna.UI2.WinForms.Guna2Button Button_Save;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel TableLayoutPanel_Paginator;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button Btn_AddNewProduct;
        private Guna.UI2.WinForms.Guna2TextBox Text_Search;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Product;
        private System.Windows.Forms.Timer Timer_Debounce;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private DataGridViewCheckBoxColumn ProductSelect;
        private DataGridViewTextBoxColumn InternalCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ColorName;
        private DataGridViewTextBoxColumn CapacityName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn CapacityId;
        private DataGridViewTextBoxColumn ColorId;
        private DataGridViewTextBoxColumn ColorInternalCode;
        private DataGridViewTextBoxColumn CategoryInternalCode;
        private DataGridViewTextBoxColumn CategoryId;
    }
}