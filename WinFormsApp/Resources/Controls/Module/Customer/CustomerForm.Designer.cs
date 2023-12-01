namespace WinFormsApp.Resources.Controls.Module.Customer
{
    partial class CustomerForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Dialog_Notification = new Guna.UI2.WinForms.Guna2MessageDialog();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            Text_InternalCode = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            Text_Name = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label6 = new Label();
            Text_Address = new Guna.UI2.WinForms.Guna2TextBox();
            Text_PhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            Label_Heading = new Label();
            Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            Button_Save = new Guna.UI2.WinForms.Guna2Button();
            FormBorderLess_Distributor = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã khách hàng";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(Text_InternalCode, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(Text_Name, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(label6, 0, 3);
            tableLayoutPanel3.Controls.Add(Text_Address, 1, 3);
            tableLayoutPanel3.Controls.Add(Text_PhoneNumber, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 47);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(9, 16, 5, 0);
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(587, 364);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // Text_InternalCode
            // 
            Text_InternalCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Text_InternalCode.BorderRadius = 5;
            Text_InternalCode.CustomizableEdges = customizableEdges1;
            Text_InternalCode.DefaultText = "";
            Text_InternalCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_InternalCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_InternalCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_InternalCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_InternalCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_InternalCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Text_InternalCode.ForeColor = Color.Black;
            Text_InternalCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_InternalCode.Location = new Point(149, 28);
            Text_InternalCode.Margin = new Padding(3, 5, 3, 5);
            Text_InternalCode.Name = "Text_InternalCode";
            Text_InternalCode.PasswordChar = '\0';
            Text_InternalCode.PlaceholderText = "Mã nhân viên";
            Text_InternalCode.SelectedText = "";
            Text_InternalCode.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_InternalCode.Size = new Size(430, 48);
            Text_InternalCode.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // Text_Name
            // 
            Text_Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Text_Name.Animated = true;
            Text_Name.BorderRadius = 5;
            Text_Name.CustomizableEdges = customizableEdges3;
            Text_Name.DefaultText = "";
            Text_Name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Name.ForeColor = Color.Black;
            Text_Name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Name.Location = new Point(149, 101);
            Text_Name.Margin = new Padding(3, 5, 3, 5);
            Text_Name.Name = "Text_Name";
            Text_Name.PasswordChar = '\0';
            Text_Name.PlaceholderText = "Tên nhân viên";
            Text_Name.SelectedText = "";
            Text_Name.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Text_Name.Size = new Size(430, 48);
            Text_Name.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 260);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 15;
            label6.Text = "Địa chỉ";
            // 
            // Text_Address
            // 
            Text_Address.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Text_Address.Animated = true;
            Text_Address.BorderRadius = 5;
            Text_Address.CustomizableEdges = customizableEdges5;
            Text_Address.DefaultText = "";
            Text_Address.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Address.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Address.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Address.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Address.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Address.ForeColor = Color.Black;
            Text_Address.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Address.Location = new Point(149, 247);
            Text_Address.Margin = new Padding(3, 5, 3, 5);
            Text_Address.Name = "Text_Address";
            Text_Address.PasswordChar = '\0';
            Text_Address.PlaceholderText = "Địa chỉ";
            Text_Address.SelectedText = "";
            Text_Address.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Text_Address.Size = new Size(430, 48);
            Text_Address.TabIndex = 16;
            // 
            // Text_PhoneNumber
            // 
            Text_PhoneNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Text_PhoneNumber.Animated = true;
            Text_PhoneNumber.BorderRadius = 5;
            Text_PhoneNumber.CustomizableEdges = customizableEdges7;
            Text_PhoneNumber.DefaultText = "";
            Text_PhoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_PhoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_PhoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_PhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_PhoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_PhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Text_PhoneNumber.ForeColor = Color.Black;
            Text_PhoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_PhoneNumber.Location = new Point(149, 174);
            Text_PhoneNumber.Margin = new Padding(3, 5, 3, 5);
            Text_PhoneNumber.Name = "Text_PhoneNumber";
            Text_PhoneNumber.PasswordChar = '\0';
            Text_PhoneNumber.PlaceholderText = "Số điện thoại";
            Text_PhoneNumber.SelectedText = "";
            Text_PhoneNumber.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Text_PhoneNumber.Size = new Size(430, 48);
            Text_PhoneNumber.TabIndex = 17;
            // 
            // Label_Heading
            // 
            Label_Heading.Anchor = AnchorStyles.None;
            Label_Heading.AutoSize = true;
            Label_Heading.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Heading.Location = new Point(202, 12);
            Label_Heading.Name = "Label_Heading";
            Label_Heading.Size = new Size(182, 23);
            Label_Heading.TabIndex = 0;
            Label_Heading.Text = "Thêm mới khách hàng";
            // 
            // Button_Cancel
            // 
            Button_Cancel.Anchor = AnchorStyles.Left;
            Button_Cancel.Animated = true;
            Button_Cancel.AnimatedGIF = true;
            Button_Cancel.BorderRadius = 8;
            Button_Cancel.CustomizableEdges = customizableEdges9;
            Button_Cancel.DisabledState.BorderColor = Color.DarkGray;
            Button_Cancel.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Cancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Cancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Cancel.FillColor = Color.DarkGray;
            Button_Cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Cancel.ForeColor = Color.White;
            Button_Cancel.Location = new Point(11, 6);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Button_Cancel.Size = new Size(80, 53);
            Button_Cancel.TabIndex = 1;
            Button_Cancel.Text = "Hủy";
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Save
            // 
            Button_Save.Anchor = AnchorStyles.Right;
            Button_Save.Animated = true;
            Button_Save.AnimatedGIF = true;
            Button_Save.BorderRadius = 8;
            Button_Save.CustomizableEdges = customizableEdges11;
            Button_Save.DisabledState.BorderColor = Color.DarkGray;
            Button_Save.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Save.FillColor = Color.FromArgb(100, 88, 255);
            Button_Save.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Save.ForeColor = Color.White;
            Button_Save.Location = new Point(496, 6);
            Button_Save.Name = "Button_Save";
            Button_Save.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Button_Save.Size = new Size(80, 53);
            Button_Save.TabIndex = 0;
            Button_Save.Text = "Lưu";
            Button_Save.Click += Button_Save_Click;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.WhiteSmoke;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(Button_Cancel, 0, 0);
            tableLayoutPanel4.Controls.Add(Button_Save, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 411);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(8, 0, 8, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(587, 65);
            tableLayoutPanel4.TabIndex = 7;
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
            tableLayoutPanel2.Size = new Size(587, 47);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 476);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Notification;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2TextBox Text_InternalCode;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Text_Name;
        private Label label4;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox Text_Address;
        private Label Label_Heading;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private Guna.UI2.WinForms.Guna2Button Button_Save;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormBorderLess_Distributor;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox Text_PhoneNumber;
    }
}