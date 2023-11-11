namespace Common.UI
{
    partial class Dialog
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            Timer_Close = new System.Windows.Forms.Timer(components);
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            Label_Text = new TableLayoutPanel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Button_Agree = new Guna.UI2.WinForms.Guna2Button();
            Button_OK = new Guna.UI2.WinForms.Guna2Button();
            Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            Label_Mess = new Label();
            guna2ShadowPanel1.SuspendLayout();
            Label_Text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 12;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.HasFormShadow = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Timer_Close
            // 
            Timer_Close.Tick += Timer_Close_Tick;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(Label_Text);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Padding = new Padding(12);
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(345, 219);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // Label_Text
            // 
            Label_Text.BackColor = Color.White;
            Label_Text.ColumnCount = 2;
            Label_Text.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.68852F));
            Label_Text.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.31148F));
            Label_Text.Controls.Add(guna2PictureBox1, 0, 0);
            Label_Text.Controls.Add(label1, 1, 0);
            Label_Text.Controls.Add(flowLayoutPanel1, 1, 2);
            Label_Text.Controls.Add(Label_Mess, 1, 1);
            Label_Text.Dock = DockStyle.Fill;
            Label_Text.Location = new Point(12, 12);
            Label_Text.Name = "Label_Text";
            Label_Text.RowCount = 3;
            Label_Text.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            Label_Text.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Label_Text.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            Label_Text.Size = new Size(321, 195);
            Label_Text.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges9;
            guna2PictureBox1.Dock = DockStyle.Fill;
            guna2PictureBox1.Image = Properties.Resources.ic_warn;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 3);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2PictureBox1.Size = new Size(53, 48);
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 17);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Thông báo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Button_Agree);
            flowLayoutPanel1.Controls.Add(Button_OK);
            flowLayoutPanel1.Controls.Add(Button_Cancel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(59, 156);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(262, 39);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // Button_Agree
            // 
            Button_Agree.Anchor = AnchorStyles.Right;
            Button_Agree.BorderRadius = 5;
            Button_Agree.CustomizableEdges = customizableEdges11;
            Button_Agree.DisabledState.BorderColor = Color.DarkGray;
            Button_Agree.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Agree.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Agree.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Agree.FillColor = Color.RoyalBlue;
            Button_Agree.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Agree.ForeColor = Color.White;
            Button_Agree.Location = new Point(189, 3);
            Button_Agree.Name = "Button_Agree";
            Button_Agree.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Button_Agree.Size = new Size(70, 35);
            Button_Agree.TabIndex = 0;
            Button_Agree.Text = "Đồng ý";
            Button_Agree.Click += Button_Agree_Click;
            // 
            // Button_OK
            // 
            Button_OK.Anchor = AnchorStyles.Right;
            Button_OK.BorderRadius = 5;
            Button_OK.CustomizableEdges = customizableEdges13;
            Button_OK.DisabledState.BorderColor = Color.DarkGray;
            Button_OK.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_OK.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_OK.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_OK.FillColor = Color.RoyalBlue;
            Button_OK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_OK.ForeColor = Color.White;
            Button_OK.Location = new Point(135, 3);
            Button_OK.Name = "Button_OK";
            Button_OK.ShadowDecoration.CustomizableEdges = customizableEdges14;
            Button_OK.Size = new Size(48, 35);
            Button_OK.TabIndex = 1;
            Button_OK.Text = "OK";
            Button_OK.Click += Button_OK_Click;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Anchor = AnchorStyles.Right;
            Button_Cancel.BorderRadius = 5;
            Button_Cancel.CustomizableEdges = customizableEdges15;
            Button_Cancel.DisabledState.BorderColor = Color.DarkGray;
            Button_Cancel.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Cancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Cancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Cancel.FillColor = Color.SlateGray;
            Button_Cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Cancel.ForeColor = Color.White;
            Button_Cancel.Location = new Point(75, 3);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            Button_Cancel.Size = new Size(54, 35);
            Button_Cancel.TabIndex = 2;
            Button_Cancel.Text = "Hủy";
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Label_Mess
            // 
            Label_Mess.AutoSize = true;
            Label_Mess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Mess.Location = new Point(62, 57);
            Label_Mess.Margin = new Padding(3);
            Label_Mess.Name = "Label_Mess";
            Label_Mess.Size = new Size(39, 15);
            Label_Mess.TabIndex = 4;
            Label_Mess.Text = "label2";
            // 
            // Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 219);
            Controls.Add(guna2ShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dialog";
            guna2ShadowPanel1.ResumeLayout(false);
            Label_Text.ResumeLayout(false);
            Label_Text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer Timer_Close;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private TableLayoutPanel Label_Text;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button Button_Agree;
        private Guna.UI2.WinForms.Guna2Button Button_OK;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private Label Label_Mess;
    }
}