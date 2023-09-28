namespace Controls.UI
{
    partial class Dropdown
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Panel_Container = new Guna.UI2.WinForms.Guna2Panel();
            Btn_TrangThai = new Guna.UI2.WinForms.Guna2Button();
            Panel_Container.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Container
            // 
            Panel_Container.AutoSize = true;
            Panel_Container.Controls.Add(Btn_TrangThai);
            Panel_Container.CustomizableEdges = customizableEdges3;
            Panel_Container.Location = new Point(0, 0);
            Panel_Container.Margin = new Padding(0);
            Panel_Container.MinimumSize = new Size(226, 0);
            Panel_Container.Name = "Panel_Container";
            Panel_Container.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Panel_Container.Size = new Size(251, 39);
            Panel_Container.TabIndex = 11;
            // 
            // Btn_TrangThai
            // 
            Btn_TrangThai.Animated = true;
            Btn_TrangThai.AnimatedGIF = true;
            Btn_TrangThai.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            Btn_TrangThai.CheckedState.FillColor = Color.Transparent;
            Btn_TrangThai.CustomizableEdges = customizableEdges1;
            Btn_TrangThai.DisabledState.BorderColor = Color.Transparent;
            Btn_TrangThai.DisabledState.CustomBorderColor = Color.Transparent;
            Btn_TrangThai.DisabledState.FillColor = Color.Transparent;
            Btn_TrangThai.DisabledState.ForeColor = Color.Transparent;
            Btn_TrangThai.Dock = DockStyle.Top;
            Btn_TrangThai.FillColor = Color.Transparent;
            Btn_TrangThai.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_TrangThai.ForeColor = Color.DodgerBlue;
            Btn_TrangThai.HoverState.FillColor = Color.Transparent;
            Btn_TrangThai.ImageAlign = HorizontalAlignment.Left;
            Btn_TrangThai.ImageSize = new Size(10, 10);
            Btn_TrangThai.Location = new Point(0, 0);
            Btn_TrangThai.Margin = new Padding(0);
            Btn_TrangThai.Name = "Btn_TrangThai";
            Btn_TrangThai.PressedColor = Color.Transparent;
            Btn_TrangThai.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Btn_TrangThai.Size = new Size(251, 39);
            Btn_TrangThai.TabIndex = 9;
            Btn_TrangThai.Text = "Change your dropdown title";
            Btn_TrangThai.TextAlign = HorizontalAlignment.Left;
            Btn_TrangThai.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Dropdown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(Panel_Container);
            Name = "Dropdown";
            Size = new Size(251, 39);
            Panel_Container.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_Container;
        private Guna.UI2.WinForms.Guna2Button Btn_TrangThai;
    }
}
