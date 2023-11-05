namespace Controls.UI
{
    partial class Paginator
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
            FlowLayoutPanel_Container = new FlowLayoutPanel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            FlowLayoutPanel_Container.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel_Container
            // 
            FlowLayoutPanel_Container.AutoSize = true;
            FlowLayoutPanel_Container.BackColor = Color.White;
            FlowLayoutPanel_Container.Controls.Add(guna2Button1);
            FlowLayoutPanel_Container.Location = new Point(0, 0);
            FlowLayoutPanel_Container.Margin = new Padding(0);
            FlowLayoutPanel_Container.Name = "FlowLayoutPanel_Container";
            FlowLayoutPanel_Container.Size = new Size(48, 46);
            FlowLayoutPanel_Container.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.RoyalBlue;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(3, 3);
            guna2Button1.Margin = new Padding(3, 3, 5, 3);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(40, 40);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "1";
            // 
            // Paginator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(FlowLayoutPanel_Container);
            Name = "Paginator";
            Size = new Size(48, 46);
            FlowLayoutPanel_Container.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FlowLayoutPanel_Container;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
