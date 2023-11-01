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
            TableLayoutPanel_Header = new TableLayoutPanel();
            Text_Parent = new Guna.UI2.WinForms.Guna2TextBox();
            ImageButton_Chevron = new Guna.UI2.WinForms.Guna2ImageButton();
            TableLayoutPanel_Container = new TableLayoutPanel();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
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
            TableLayoutPanel_Header.Size = new Size(679, 52);
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
            Text_Parent.Size = new Size(643, 44);
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
            ImageButton_Chevron.Location = new Point(654, 3);
            ImageButton_Chevron.Name = "ImageButton_Chevron";
            ImageButton_Chevron.PressedState.ImageSize = new Size(12, 12);
            ImageButton_Chevron.ShadowDecoration.CustomizableEdges = customizableEdges3;
            ImageButton_Chevron.Size = new Size(22, 46);
            ImageButton_Chevron.TabIndex = 5;
            ImageButton_Chevron.Click += ImageButton_Chevron_Click;
            // 
            // TableLayoutPanel_Container
            // 
            TableLayoutPanel_Container.ColumnCount = 2;
            TableLayoutPanel_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableLayoutPanel_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TableLayoutPanel_Container.Controls.Add(guna2TextBox2, 0, 0);
            TableLayoutPanel_Container.Controls.Add(guna2TextBox1, 0, 0);
            TableLayoutPanel_Container.Dock = DockStyle.Fill;
            TableLayoutPanel_Container.Location = new Point(0, 52);
            TableLayoutPanel_Container.Margin = new Padding(3, 8, 3, 3);
            TableLayoutPanel_Container.Name = "TableLayoutPanel_Container";
            TableLayoutPanel_Container.Padding = new Padding(0, 8, 0, 0);
            TableLayoutPanel_Container.RowCount = 1;
            TableLayoutPanel_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Container.Size = new Size(679, 53);
            TableLayoutPanel_Container.TabIndex = 6;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.CustomizableEdges = customizableEdges4;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.Dock = DockStyle.Fill;
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(283, 11);
            guna2TextBox2.Margin = new Padding(12, 3, 3, 3);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderText = "Giá trị thông số";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2TextBox2.Size = new Size(393, 39);
            guna2TextBox2.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges6;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.Dock = DockStyle.Fill;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(3, 11);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Tên thông số";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2TextBox1.Size = new Size(265, 39);
            guna2TextBox1.TabIndex = 0;
            // 
            // ParameterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel_Container);
            Controls.Add(TableLayoutPanel_Header);
            Margin = new Padding(3, 3, 3, 12);
            MinimumSize = new Size(0, 50);
            Name = "ParameterItem";
            Padding = new Padding(0, 0, 0, 12);
            Size = new Size(679, 117);
            TableLayoutPanel_Header.ResumeLayout(false);
            TableLayoutPanel_Container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_Header;
        private Guna.UI2.WinForms.Guna2TextBox Text_Parent;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButton_Chevron;
        private TableLayoutPanel TableLayoutPanel_Container;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}
