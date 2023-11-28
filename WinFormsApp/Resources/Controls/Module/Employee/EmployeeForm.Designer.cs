namespace WinFormsApp.Resources.Controls.Module.Employee
{
    partial class EmployeeForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            FormBorderLess_Distributor = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            Button_Save = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            Text_InternalCode = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            Text_Name = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Text_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            DateTime_Birthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ComboBox_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            Dialog_Notification = new Guna.UI2.WinForms.Guna2MessageDialog();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
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
            // Button_Cancel
            // 
            Button_Cancel.Anchor = AnchorStyles.Left;
            Button_Cancel.Animated = true;
            Button_Cancel.AnimatedGIF = true;
            Button_Cancel.BorderRadius = 8;
            Button_Cancel.CustomizableEdges = customizableEdges11;
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
            Button_Cancel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Button_Cancel.Size = new Size(70, 40);
            Button_Cancel.TabIndex = 1;
            Button_Cancel.Text = "Hủy";
            Button_Cancel.Click += Button_Cancel_Click;
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
            tableLayoutPanel4.Location = new Point(0, 390);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(7, 0, 7, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(514, 49);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // Button_Save
            // 
            Button_Save.Anchor = AnchorStyles.Right;
            Button_Save.Animated = true;
            Button_Save.AnimatedGIF = true;
            Button_Save.BorderRadius = 8;
            Button_Save.CustomizableEdges = customizableEdges13;
            Button_Save.DisabledState.BorderColor = Color.DarkGray;
            Button_Save.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Save.FillColor = Color.FromArgb(100, 88, 255);
            Button_Save.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Save.ForeColor = Color.White;
            Button_Save.Location = new Point(434, 4);
            Button_Save.Margin = new Padding(3, 2, 3, 2);
            Button_Save.Name = "Button_Save";
            Button_Save.ShadowDecoration.CustomizableEdges = customizableEdges14;
            Button_Save.Size = new Size(70, 40);
            Button_Save.TabIndex = 0;
            Button_Save.Text = "Lưu";
            Button_Save.Click += Button_Save_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(100, 88, 255);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.11203F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.ForeColor = Color.White;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(514, 35);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 8);
            label1.Name = "label1";
            label1.Size = new Size(138, 19);
            label1.TabIndex = 0;
            label1.Text = "Thêm mới nhân viên";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(Text_InternalCode, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(Text_Name, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(label5, 0, 3);
            tableLayoutPanel3.Controls.Add(label6, 0, 4);
            tableLayoutPanel3.Controls.Add(Text_Phone, 1, 4);
            tableLayoutPanel3.Controls.Add(DateTime_Birthday, 1, 3);
            tableLayoutPanel3.Controls.Add(ComboBox_Gender, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 35);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(8, 12, 4, 0);
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(514, 355);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 30);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
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
            Text_InternalCode.Location = new Point(131, 21);
            Text_InternalCode.Margin = new Padding(3, 4, 3, 4);
            Text_InternalCode.Name = "Text_InternalCode";
            Text_InternalCode.PasswordChar = '\0';
            Text_InternalCode.PlaceholderText = "Mã nhân viên";
            Text_InternalCode.SelectedText = "";
            Text_InternalCode.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_InternalCode.Size = new Size(376, 36);
            Text_InternalCode.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 85);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 2;
            label3.Text = "Tên nhân viên";
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
            Text_Name.Location = new Point(131, 76);
            Text_Name.Margin = new Padding(3, 4, 3, 4);
            Text_Name.Name = "Text_Name";
            Text_Name.PasswordChar = '\0';
            Text_Name.PlaceholderText = "Tên nhân viên";
            Text_Name.SelectedText = "";
            Text_Name.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Text_Name.Size = new Size(376, 36);
            Text_Name.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 140);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 4;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 195);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 5;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 250);
            label6.Name = "label6";
            label6.Size = new Size(93, 19);
            label6.TabIndex = 15;
            label6.Text = "Số điện thoại";
            // 
            // Text_Phone
            // 
            Text_Phone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Text_Phone.Animated = true;
            Text_Phone.BorderRadius = 5;
            Text_Phone.CustomizableEdges = customizableEdges5;
            Text_Phone.DefaultText = "";
            Text_Phone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Phone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Phone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Phone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Phone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Phone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Phone.ForeColor = Color.Black;
            Text_Phone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Phone.Location = new Point(131, 241);
            Text_Phone.Margin = new Padding(3, 4, 3, 4);
            Text_Phone.Name = "Text_Phone";
            Text_Phone.PasswordChar = '\0';
            Text_Phone.PlaceholderText = "Số điện thoại";
            Text_Phone.SelectedText = "";
            Text_Phone.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Text_Phone.Size = new Size(376, 36);
            Text_Phone.TabIndex = 16;
            // 
            // DateTime_Birthday
            // 
            DateTime_Birthday.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DateTime_Birthday.BackColor = Color.White;
            DateTime_Birthday.BorderRadius = 5;
            DateTime_Birthday.Checked = true;
            DateTime_Birthday.CustomFormat = "dd/MM/yyyy";
            DateTime_Birthday.CustomizableEdges = customizableEdges7;
            DateTime_Birthday.FillColor = Color.White;
            DateTime_Birthday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DateTime_Birthday.Format = DateTimePickerFormat.Custom;
            DateTime_Birthday.Location = new Point(131, 186);
            DateTime_Birthday.Margin = new Padding(3, 2, 3, 2);
            DateTime_Birthday.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTime_Birthday.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTime_Birthday.Name = "DateTime_Birthday";
            DateTime_Birthday.ShadowDecoration.CustomizableEdges = customizableEdges8;
            DateTime_Birthday.Size = new Size(376, 36);
            DateTime_Birthday.TabIndex = 18;
            DateTime_Birthday.Value = new DateTime(2023, 11, 1, 9, 1, 37, 831);
            // 
            // ComboBox_Gender
            // 
            ComboBox_Gender.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBox_Gender.BackColor = Color.Transparent;
            ComboBox_Gender.BorderRadius = 5;
            ComboBox_Gender.CustomizableEdges = customizableEdges9;
            ComboBox_Gender.DisplayMember = "Nam";
            ComboBox_Gender.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBox_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Gender.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBox_Gender.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBox_Gender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_Gender.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBox_Gender.ItemHeight = 30;
            ComboBox_Gender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            ComboBox_Gender.Location = new Point(131, 131);
            ComboBox_Gender.Name = "ComboBox_Gender";
            ComboBox_Gender.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ComboBox_Gender.Size = new Size(376, 36);
            ComboBox_Gender.TabIndex = 19;
            // 
            // Dialog_Notification
            // 
            Dialog_Notification.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            Dialog_Notification.Caption = "Thông báo";
            Dialog_Notification.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            Dialog_Notification.Parent = this;
            Dialog_Notification.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            Dialog_Notification.Text = null;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 439);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormBorderLess_Distributor;
        private TableLayoutPanel TableLayoutPanel_Container;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Text_InternalCode;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Text_Name;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private Guna.UI2.WinForms.Guna2Button Button_Save;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox Text_Phone;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTime_Birthday;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Sex;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Gender;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Notification;
    }
}