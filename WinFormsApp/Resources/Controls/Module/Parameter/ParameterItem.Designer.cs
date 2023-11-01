namespace WinFormsApp.Resources.Controls.Module.Parameter
{
    partial class ParameterItem
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TableLayoutPanel_Header = new TableLayoutPanel();
            Text_Parent = new Guna.UI2.WinForms.Guna2TextBox();
            ImageButton_Chevron = new Guna.UI2.WinForms.Guna2ImageButton();
            TableLayoutPanel_Container = new TableLayoutPanel();
            Btn_Create = new Guna.UI2.WinForms.Guna2Button();
            Text_Value = new Guna.UI2.WinForms.Guna2TextBox();
            Text_Name = new Guna.UI2.WinForms.Guna2TextBox();
            TableLayoutPanel_Header.SuspendLayout();
            TableLayoutPanel_Container.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel_Header
            // 
            TableLayoutPanel_Header.ColumnCount = 2;
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            TableLayoutPanel_Header.Controls.Add(Text_Parent, 0, 0);
            TableLayoutPanel_Header.Controls.Add(ImageButton_Chevron, 1, 0);
            TableLayoutPanel_Header.Dock = DockStyle.Top;
            TableLayoutPanel_Header.Location = new Point(0, 0);
            TableLayoutPanel_Header.Name = "TableLayoutPanel_Header";
            TableLayoutPanel_Header.RowCount = 1;
            TableLayoutPanel_Header.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Header.Size = new Size(586, 52);
            TableLayoutPanel_Header.TabIndex = 5;
            // 
            // Text_Parent
            // 
            Text_Parent.CustomizableEdges = customizableEdges1;
            Text_Parent.DefaultText = "";
            Text_Parent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Parent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Parent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Parent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Parent.Dock = DockStyle.Fill;
            Text_Parent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Parent.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Text_Parent.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Parent.IconRightOffset = new Point(8, 0);
            Text_Parent.IconRightSize = new Size(10, 10);
            Text_Parent.Location = new Point(4, 4);
            Text_Parent.Margin = new Padding(4);
            Text_Parent.Name = "Text_Parent";
            Text_Parent.Padding = new Padding(0, 0, 8, 0);
            Text_Parent.PasswordChar = '\0';
            Text_Parent.PlaceholderText = "Thông số kỹ thuật";
            Text_Parent.SelectedText = "";
            Text_Parent.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_Parent.Size = new Size(550, 44);
            Text_Parent.TabIndex = 4;
            // 
            // ImageButton_Chevron
            // 
            ImageButton_Chevron.CheckedState.ImageSize = new Size(12, 12);
            ImageButton_Chevron.Dock = DockStyle.Fill;
            ImageButton_Chevron.HoverState.ImageSize = new Size(12, 12);
            ImageButton_Chevron.Image = Properties.Resources.arrow_down;
            ImageButton_Chevron.ImageOffset = new Point(0, 0);
            ImageButton_Chevron.ImageRotate = 0F;
            ImageButton_Chevron.ImageSize = new Size(12, 12);
            ImageButton_Chevron.Location = new Point(561, 3);
            ImageButton_Chevron.Name = "ImageButton_Chevron";
            ImageButton_Chevron.PressedState.ImageSize = new Size(12, 12);
            ImageButton_Chevron.ShadowDecoration.CustomizableEdges = customizableEdges3;
            ImageButton_Chevron.Size = new Size(22, 46);
            ImageButton_Chevron.TabIndex = 5;
            ImageButton_Chevron.Click += ImageButton_Chevron_Click;
            // 
            // TableLayoutPanel_Container
            // 
            TableLayoutPanel_Container.ColumnCount = 3;
            TableLayoutPanel_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableLayoutPanel_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TableLayoutPanel_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            TableLayoutPanel_Container.Controls.Add(Btn_Create, 0, 0);
            TableLayoutPanel_Container.Controls.Add(Text_Value, 0, 0);
            TableLayoutPanel_Container.Controls.Add(Text_Name, 0, 0);
            TableLayoutPanel_Container.Dock = DockStyle.Top;
            TableLayoutPanel_Container.Location = new Point(0, 52);
            TableLayoutPanel_Container.Margin = new Padding(3, 8, 3, 3);
            TableLayoutPanel_Container.Name = "TableLayoutPanel_Container";
            TableLayoutPanel_Container.Padding = new Padding(0, 8, 0, 0);
            TableLayoutPanel_Container.RowCount = 1;
            TableLayoutPanel_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Container.Size = new Size(586, 50);
            TableLayoutPanel_Container.TabIndex = 6;
            // 
            // Btn_Create
            // 
            Btn_Create.AnimatedGIF = true;
            Btn_Create.BorderRadius = 8;
            Btn_Create.CustomizableEdges = customizableEdges4;
            Btn_Create.DisabledState.BorderColor = Color.DarkGray;
            Btn_Create.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn_Create.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn_Create.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn_Create.Dock = DockStyle.Fill;
            Btn_Create.FillColor = Color.FromArgb(100, 88, 255);
            Btn_Create.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Create.ForeColor = Color.White;
            Btn_Create.Location = new Point(528, 11);
            Btn_Create.Name = "Btn_Create";
            Btn_Create.ShadowDecoration.CustomizableEdges = customizableEdges5;
            Btn_Create.Size = new Size(55, 36);
            Btn_Create.TabIndex = 2;
            Btn_Create.Text = "Lưu";
            Btn_Create.Click += Button_Create_Click;
            // 
            // Text_Value
            // 
            Text_Value.CustomizableEdges = customizableEdges6;
            Text_Value.DefaultText = "";
            Text_Value.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Value.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Value.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Value.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Value.Dock = DockStyle.Fill;
            Text_Value.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Value.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Text_Value.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Value.Location = new Point(222, 11);
            Text_Value.Margin = new Padding(12, 3, 3, 3);
            Text_Value.Name = "Text_Value";
            Text_Value.PasswordChar = '\0';
            Text_Value.PlaceholderText = "Giá trị thông số";
            Text_Value.SelectedText = "";
            Text_Value.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Text_Value.Size = new Size(300, 36);
            Text_Value.TabIndex = 1;
            // 
            // Text_Name
            // 
            Text_Name.CustomizableEdges = customizableEdges8;
            Text_Name.DefaultText = "";
            Text_Name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Name.Dock = DockStyle.Fill;
            Text_Name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Name.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Text_Name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Name.Location = new Point(3, 11);
            Text_Name.Name = "Text_Name";
            Text_Name.PasswordChar = '\0';
            Text_Name.PlaceholderText = "Tên thông số";
            Text_Name.SelectedText = "";
            Text_Name.ShadowDecoration.CustomizableEdges = customizableEdges9;
            Text_Name.Size = new Size(204, 36);
            Text_Name.TabIndex = 0;
            // 
            // ParameterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel_Container);
            Controls.Add(TableLayoutPanel_Header);
            Margin = new Padding(3, 3, 3, 12);
            MaximumSize = new Size(0, 114);
            MinimumSize = new Size(0, 65);
            Name = "ParameterItem";
            Padding = new Padding(0, 0, 0, 12);
            Size = new Size(586, 114);
            TableLayoutPanel_Header.ResumeLayout(false);
            TableLayoutPanel_Container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_Header;
        private Guna.UI2.WinForms.Guna2TextBox Text_Parent;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButton_Chevron;
        private TableLayoutPanel TableLayoutPanel_Container;
        private Guna.UI2.WinForms.Guna2TextBox Text_Value;
        private Guna.UI2.WinForms.Guna2TextBox Text_Name;
        private Guna.UI2.WinForms.Guna2Button Btn_Create;
    }
}
