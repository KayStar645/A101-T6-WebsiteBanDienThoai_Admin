namespace WinFormsApp.Resources.Controls.Module.Role
{
    partial class RoleForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Dialog_Notification = new Guna.UI2.WinForms.Guna2MessageDialog();
            Label_Heading = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            Button_Save = new Guna.UI2.WinForms.Guna2Button();
            FormBorderLess_Distributor = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            TableLayoutPanel_Body = new TableLayoutPanel();
            Text_Name = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            Panel_Body = new Panel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            TableLayoutPanel_Body.SuspendLayout();
            SuspendLayout();
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
            // Label_Heading
            // 
            Label_Heading.Anchor = AnchorStyles.None;
            Label_Heading.AutoSize = true;
            Label_Heading.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Heading.Location = new Point(179, 8);
            Label_Heading.Name = "Label_Heading";
            Label_Heading.Size = new Size(115, 19);
            Label_Heading.TabIndex = 0;
            Label_Heading.Text = "Thêm mới quyền";
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
            tableLayoutPanel2.Size = new Size(474, 35);
            tableLayoutPanel2.TabIndex = 8;
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
            tableLayoutPanel4.Location = new Point(0, 571);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(7, 0, 7, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(474, 49);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Anchor = AnchorStyles.Left;
            Button_Cancel.Animated = true;
            Button_Cancel.AnimatedGIF = true;
            Button_Cancel.BorderRadius = 8;
            Button_Cancel.CustomizableEdges = customizableEdges3;
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
            Button_Cancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Cancel.Size = new Size(70, 40);
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
            Button_Save.CustomizableEdges = customizableEdges5;
            Button_Save.DisabledState.BorderColor = Color.DarkGray;
            Button_Save.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Save.FillColor = Color.FromArgb(100, 88, 255);
            Button_Save.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Save.ForeColor = Color.White;
            Button_Save.Location = new Point(394, 4);
            Button_Save.Margin = new Padding(3, 2, 3, 2);
            Button_Save.Name = "Button_Save";
            Button_Save.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Button_Save.Size = new Size(70, 40);
            Button_Save.TabIndex = 0;
            Button_Save.Text = "Lưu";
            Button_Save.Click += Button_Save_Click;
            // 
            // FormBorderLess_Distributor
            // 
            FormBorderLess_Distributor.AnimateWindow = true;
            FormBorderLess_Distributor.AnimationInterval = 300;
            FormBorderLess_Distributor.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            FormBorderLess_Distributor.BorderRadius = 10;
            FormBorderLess_Distributor.ContainerControl = this;
            FormBorderLess_Distributor.DockIndicatorColor = Color.Black;
            FormBorderLess_Distributor.DockIndicatorTransparencyValue = 0.6D;
            FormBorderLess_Distributor.TransparentWhileDrag = true;
            // 
            // TableLayoutPanel_Body
            // 
            TableLayoutPanel_Body.ColumnCount = 2;
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.Controls.Add(Text_Name, 1, 0);
            TableLayoutPanel_Body.Controls.Add(label2, 0, 0);
            TableLayoutPanel_Body.Controls.Add(Panel_Body, 0, 1);
            TableLayoutPanel_Body.Dock = DockStyle.Fill;
            TableLayoutPanel_Body.Location = new Point(0, 35);
            TableLayoutPanel_Body.Name = "TableLayoutPanel_Body";
            TableLayoutPanel_Body.RowCount = 2;
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            TableLayoutPanel_Body.Size = new Size(474, 536);
            TableLayoutPanel_Body.TabIndex = 9;
            // 
            // Text_Name
            // 
            Text_Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Text_Name.BorderRadius = 5;
            Text_Name.CustomizableEdges = customizableEdges1;
            Text_Name.DefaultText = "";
            Text_Name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Name.ForeColor = Color.Black;
            Text_Name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Name.Location = new Point(123, 9);
            Text_Name.Margin = new Padding(3, 4, 3, 4);
            Text_Name.Name = "Text_Name";
            Text_Name.PasswordChar = '\0';
            Text_Name.PlaceholderText = "Tên quyền";
            Text_Name.SelectedText = "";
            Text_Name.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_Name.Size = new Size(348, 36);
            Text_Name.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 11;
            label2.Text = "Tên quyền";
            // 
            // Panel_Body
            // 
            Panel_Body.AutoScroll = true;
            TableLayoutPanel_Body.SetColumnSpan(Panel_Body, 2);
            Panel_Body.Dock = DockStyle.Fill;
            Panel_Body.Location = new Point(0, 55);
            Panel_Body.Margin = new Padding(0);
            Panel_Body.Name = "Panel_Body";
            Panel_Body.Size = new Size(474, 481);
            Panel_Body.TabIndex = 10;
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 620);
            Controls.Add(TableLayoutPanel_Body);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoleForm";
            StartPosition = FormStartPosition.Manual;
            Text = "RoleForm";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel_Body.ResumeLayout(false);
            TableLayoutPanel_Body.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Notification;
        private Label Label_Heading;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private Guna.UI2.WinForms.Guna2Button Button_Save;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormBorderLess_Distributor;
        private TableLayoutPanel TableLayoutPanel_Body;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Text_Name;
        private Panel Panel_Body;
    }
}