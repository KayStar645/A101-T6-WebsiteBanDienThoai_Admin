namespace WinFormsApp.Resources.Controls.Module.Product
{
    partial class ProductParamDetailForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            TableLayoutPanel_Header = new TableLayoutPanel();
            Label_Heading = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            Button_Save = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            DataGridView_Parameter = new Guna.UI2.WinForms.Guna2DataGridView();
            DetailSpecification_Id = new DataGridViewTextBoxColumn();
            Select = new DataGridViewCheckBoxColumn();
            SpecificationsId = new DataGridViewTextBoxColumn();
            Parameter_Name = new DataGridViewTextBoxColumn();
            Parameter_Description = new DataGridViewTextBoxColumn();
            TableLayoutPanel_Header.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Parameter).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 12;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // TableLayoutPanel_Header
            // 
            TableLayoutPanel_Header.ColumnCount = 1;
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TableLayoutPanel_Header.Controls.Add(Label_Heading, 0, 0);
            TableLayoutPanel_Header.Dock = DockStyle.Top;
            TableLayoutPanel_Header.Location = new Point(0, 0);
            TableLayoutPanel_Header.Name = "TableLayoutPanel_Header";
            TableLayoutPanel_Header.RowCount = 1;
            TableLayoutPanel_Header.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Header.Size = new Size(621, 35);
            TableLayoutPanel_Header.TabIndex = 1;
            // 
            // Label_Heading
            // 
            Label_Heading.Anchor = AnchorStyles.None;
            Label_Heading.AutoSize = true;
            Label_Heading.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Heading.ForeColor = Color.White;
            Label_Heading.Location = new Point(249, 8);
            Label_Heading.Name = "Label_Heading";
            Label_Heading.Size = new Size(122, 19);
            Label_Heading.TabIndex = 9;
            Label_Heading.Text = "Thông số kỹ thuật";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Button_Cancel, 0, 0);
            tableLayoutPanel1.Controls.Add(Button_Save, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 380);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(621, 50);
            tableLayoutPanel1.TabIndex = 2;
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
            Button_Cancel.Location = new Point(3, 5);
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
            Button_Save.Location = new Point(548, 5);
            Button_Save.Margin = new Padding(3, 2, 3, 2);
            Button_Save.Name = "Button_Save";
            Button_Save.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Save.Size = new Size(70, 40);
            Button_Save.TabIndex = 1;
            Button_Save.Text = "Lưu";
            Button_Save.Click += Button_Save_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DataGridView_Parameter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 345);
            panel1.TabIndex = 3;
            // 
            // DataGridView_Parameter
            // 
            DataGridView_Parameter.AllowUserToAddRows = false;
            DataGridView_Parameter.AllowUserToDeleteRows = false;
            DataGridView_Parameter.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridView_Parameter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_Parameter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_Parameter.ColumnHeadersHeight = 40;
            DataGridView_Parameter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Parameter.Columns.AddRange(new DataGridViewColumn[] { DetailSpecification_Id, Select, SpecificationsId, Parameter_Name, Parameter_Description });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_Parameter.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_Parameter.Dock = DockStyle.Fill;
            DataGridView_Parameter.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Parameter.Location = new Point(0, 0);
            DataGridView_Parameter.Margin = new Padding(0);
            DataGridView_Parameter.Name = "DataGridView_Parameter";
            DataGridView_Parameter.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridView_Parameter.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_Parameter.RowHeadersVisible = false;
            DataGridView_Parameter.RowHeadersWidth = 40;
            DataGridView_Parameter.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Parameter.RowTemplate.Height = 40;
            DataGridView_Parameter.Size = new Size(621, 345);
            DataGridView_Parameter.TabIndex = 7;
            DataGridView_Parameter.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_Parameter.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_Parameter.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_Parameter.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_Parameter.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_Parameter.ThemeStyle.BackColor = Color.White;
            DataGridView_Parameter.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Parameter.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_Parameter.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_Parameter.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridView_Parameter.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_Parameter.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Parameter.ThemeStyle.HeaderStyle.Height = 40;
            DataGridView_Parameter.ThemeStyle.ReadOnly = false;
            DataGridView_Parameter.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_Parameter.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_Parameter.ThemeStyle.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Parameter.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Parameter.ThemeStyle.RowsStyle.Height = 40;
            DataGridView_Parameter.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_Parameter.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Parameter.CellClick += DataGridView_Parameter_CellClick;
            // 
            // DetailSpecification_Id
            // 
            DetailSpecification_Id.DataPropertyName = "Id";
            DetailSpecification_Id.HeaderText = "Id";
            DetailSpecification_Id.Name = "DetailSpecification_Id";
            DetailSpecification_Id.Visible = false;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Select.FalseValue = "False";
            Select.HeaderText = "";
            Select.Name = "Select";
            Select.TrueValue = "True";
            Select.Width = 40;
            // 
            // SpecificationsId
            // 
            SpecificationsId.DataPropertyName = "SpecificationsId";
            SpecificationsId.HeaderText = "SpecificationsId";
            SpecificationsId.Name = "SpecificationsId";
            SpecificationsId.Visible = false;
            // 
            // Parameter_Name
            // 
            Parameter_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Parameter_Name.DataPropertyName = "Name";
            Parameter_Name.FillWeight = 41.4820366F;
            Parameter_Name.HeaderText = "Thông số";
            Parameter_Name.MinimumWidth = 6;
            Parameter_Name.Name = "Parameter_Name";
            Parameter_Name.Resizable = DataGridViewTriState.True;
            Parameter_Name.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Parameter_Description
            // 
            Parameter_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Parameter_Description.DataPropertyName = "Description";
            Parameter_Description.HeaderText = "Giá trị";
            Parameter_Description.Name = "Parameter_Description";
            Parameter_Description.ReadOnly = true;
            // 
            // ProductParamDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(621, 430);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(TableLayoutPanel_Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductParamDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductParamDetailForm";
            TableLayoutPanel_Header.ResumeLayout(false);
            TableLayoutPanel_Header.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Parameter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private TableLayoutPanel TableLayoutPanel_Header;
        private Label Label_Heading;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button Button_Save;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Parameter;
        private DataGridViewTextBoxColumn DetailSpecification_Id;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn SpecificationsId;
        private DataGridViewTextBoxColumn Parameter_Name;
        private DataGridViewTextBoxColumn Parameter_Description;
    }
}