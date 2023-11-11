namespace WinFormsApp.Resources.Controls.Module.Product
{
    partial class ProductImageForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            Button_Save = new Guna.UI2.WinForms.Guna2Button();
            TableLayoutPanel_Header = new TableLayoutPanel();
            Label_Heading = new Label();
            Dialog_Notification = new Guna.UI2.WinForms.Guna2MessageDialog();
            DataGridView_Images = new Guna.UI2.WinForms.Guna2DataGridView();
            tableLayoutPanel1.SuspendLayout();
            TableLayoutPanel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Images).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 12;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
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
            tableLayoutPanel1.Location = new Point(0, 343);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8, 0, 8, 0);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(588, 47);
            tableLayoutPanel1.TabIndex = 5;
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
            Button_Cancel.Location = new Point(11, 3);
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
            Button_Save.Location = new Point(507, 3);
            Button_Save.Margin = new Padding(3, 2, 3, 2);
            Button_Save.Name = "Button_Save";
            Button_Save.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Save.Size = new Size(70, 40);
            Button_Save.TabIndex = 1;
            Button_Save.Text = "Lưu";
            Button_Save.Click += Button_Save_Click;
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
            TableLayoutPanel_Header.Size = new Size(588, 35);
            TableLayoutPanel_Header.TabIndex = 6;
            // 
            // Label_Heading
            // 
            Label_Heading.Anchor = AnchorStyles.None;
            Label_Heading.AutoSize = true;
            Label_Heading.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Heading.ForeColor = Color.White;
            Label_Heading.Location = new Point(243, 8);
            Label_Heading.Name = "Label_Heading";
            Label_Heading.Size = new Size(101, 19);
            Label_Heading.TabIndex = 9;
            Label_Heading.Text = "Danh sách ảnh";
            // 
            // Dialog_Notification
            // 
            Dialog_Notification.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            Dialog_Notification.Caption = "Thông báo";
            Dialog_Notification.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            Dialog_Notification.Parent = this;
            Dialog_Notification.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            Dialog_Notification.Text = "Đường dẫn ảnh không hợp lệ";
            // 
            // DataGridView_Images
            // 
            DataGridView_Images.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridView_Images.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_Images.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_Images.ColumnHeadersHeight = 40;
            DataGridView_Images.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_Images.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_Images.Dock = DockStyle.Fill;
            DataGridView_Images.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Images.Location = new Point(0, 35);
            DataGridView_Images.Margin = new Padding(0);
            DataGridView_Images.Name = "DataGridView_Images";
            DataGridView_Images.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridView_Images.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_Images.RowHeadersVisible = false;
            DataGridView_Images.RowHeadersWidth = 40;
            DataGridView_Images.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridView_Images.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Images.RowTemplate.Height = 40;
            DataGridView_Images.Size = new Size(588, 308);
            DataGridView_Images.TabIndex = 8;
            DataGridView_Images.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_Images.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_Images.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_Images.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_Images.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_Images.ThemeStyle.BackColor = Color.White;
            DataGridView_Images.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Images.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_Images.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_Images.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridView_Images.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_Images.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Images.ThemeStyle.HeaderStyle.Height = 40;
            DataGridView_Images.ThemeStyle.ReadOnly = false;
            DataGridView_Images.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_Images.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_Images.ThemeStyle.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridView_Images.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Images.ThemeStyle.RowsStyle.Height = 40;
            DataGridView_Images.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_Images.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ProductImageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(588, 390);
            Controls.Add(DataGridView_Images);
            Controls.Add(TableLayoutPanel_Header);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductImageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductImage";
            tableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel_Header.ResumeLayout(false);
            TableLayoutPanel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Images).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private Guna.UI2.WinForms.Guna2Button Button_Save;
        private TableLayoutPanel TableLayoutPanel_Header;
        private Label Label_Heading;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Notification;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Images;
    }
}