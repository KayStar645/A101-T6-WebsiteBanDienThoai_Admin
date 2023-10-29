namespace WinFormsApp.View.Auth
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Label_Greeting = new Label();
            label1 = new Label();
            label2 = new Label();
            Txt_Account = new Guna.UI2.WinForms.Guna2TextBox();
            Txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            Btn_Login = new Guna.UI2.WinForms.Guna2Button();
            Dialog_ThongBao = new Guna.UI2.WinForms.Guna2MessageDialog();
            label3 = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            guna2Panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(tableLayoutPanel1);
            guna2Panel1.CustomBorderColor = Color.RoyalBlue;
            guna2Panel1.CustomBorderThickness = new Padding(3, 0, 3, 3);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 35);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(540, 267);
            guna2Panel1.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Controls.Add(Label_Greeting, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(Txt_Account, 2, 1);
            tableLayoutPanel1.Controls.Add(Txt_Password, 2, 2);
            tableLayoutPanel1.Controls.Add(Btn_Login, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(540, 267);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // Label_Greeting
            // 
            Label_Greeting.Anchor = AnchorStyles.None;
            Label_Greeting.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(Label_Greeting, 2);
            Label_Greeting.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Greeting.ForeColor = Color.RoyalBlue;
            Label_Greeting.Location = new Point(140, 27);
            Label_Greeting.Name = "Label_Greeting";
            Label_Greeting.Size = new Size(259, 32);
            Label_Greeting.TabIndex = 6;
            Label_Greeting.Text = "Đăng nhập để tiếp tục";
            Label_Greeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 106);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 3;
            label1.Tag = "GetLabel";
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 166);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 4;
            label2.Tag = "GetLabel";
            label2.Text = "Mật khẩu";
            // 
            // Txt_Account
            // 
            Txt_Account.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Txt_Account.Animated = true;
            Txt_Account.BorderRadius = 5;
            Txt_Account.Cursor = Cursors.IBeam;
            Txt_Account.CustomizableEdges = customizableEdges1;
            Txt_Account.DefaultText = "";
            Txt_Account.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Txt_Account.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Txt_Account.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Txt_Account.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Txt_Account.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Txt_Account.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Account.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Txt_Account.Location = new Point(221, 98);
            Txt_Account.Margin = new Padding(4);
            Txt_Account.MaxLength = 20;
            Txt_Account.Name = "Txt_Account";
            Txt_Account.PasswordChar = '\0';
            Txt_Account.PlaceholderText = "";
            Txt_Account.SelectedText = "";
            Txt_Account.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Txt_Account.Size = new Size(225, 37);
            Txt_Account.TabIndex = 3;
            Txt_Account.Tag = "Tên đăng nhập|";
            // 
            // Txt_Password
            // 
            Txt_Password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Txt_Password.Animated = true;
            Txt_Password.BorderRadius = 5;
            Txt_Password.Cursor = Cursors.IBeam;
            Txt_Password.CustomizableEdges = customizableEdges3;
            Txt_Password.DefaultText = "";
            Txt_Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Txt_Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Txt_Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Txt_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Txt_Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Txt_Password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Txt_Password.Location = new Point(221, 158);
            Txt_Password.Margin = new Padding(4);
            Txt_Password.MaxLength = 20;
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PasswordChar = '●';
            Txt_Password.PlaceholderText = "";
            Txt_Password.SelectedText = "";
            Txt_Password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Txt_Password.Size = new Size(225, 37);
            Txt_Password.TabIndex = 4;
            Txt_Password.Tag = "Mật khẩu|";
            Txt_Password.UseSystemPasswordChar = true;
            // 
            // Btn_Login
            // 
            Btn_Login.Anchor = AnchorStyles.Right;
            Btn_Login.Animated = true;
            Btn_Login.AnimatedGIF = true;
            Btn_Login.BackColor = Color.Transparent;
            Btn_Login.BorderColor = Color.Transparent;
            Btn_Login.BorderRadius = 5;
            Btn_Login.CustomizableEdges = customizableEdges5;
            Btn_Login.DisabledState.BorderColor = Color.DarkGray;
            Btn_Login.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn_Login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn_Login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn_Login.FillColor = Color.RoyalBlue;
            Btn_Login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Login.ForeColor = Color.White;
            Btn_Login.Location = new Point(334, 215);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Btn_Login.Size = new Size(113, 44);
            Btn_Login.TabIndex = 5;
            Btn_Login.Text = "Đăng nhập";
            Btn_Login.Click += Btn_Login_Click;
            // 
            // Dialog_ThongBao
            // 
            Dialog_ThongBao.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            Dialog_ThongBao.Caption = ".NET thông báo";
            Dialog_ThongBao.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            Dialog_ThongBao.Parent = null;
            Dialog_ThongBao.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            Dialog_ThongBao.Text = "Vui lòng điền vào ô dữ liệu được yêu cầu";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(231, 8);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 3;
            label3.Text = "Đăng nhập";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges9;
            guna2ControlBox1.FillColor = Color.RoyalBlue;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(502, 0);
            guna2ControlBox1.Margin = new Padding(0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2ControlBox1.Size = new Size(38, 29);
            guna2ControlBox1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.RoyalBlue;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel6.Controls.Add(label3, 1, 0);
            tableLayoutPanel6.Controls.Add(guna2ControlBox1, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(540, 35);
            tableLayoutPanel6.TabIndex = 17;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 302);
            Controls.Add(guna2Panel1);
            Controls.Add(tableLayoutPanel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            guna2Panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Label_Greeting;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Password;
        private Guna.UI2.WinForms.Guna2Button Btn_Login;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Account;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_ThongBao;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private TableLayoutPanel tableLayoutPanel6;
    }
}