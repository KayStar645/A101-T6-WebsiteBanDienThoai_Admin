namespace Controls.UI
{
    partial class PaginatorButton
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
            Btn_Container = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // Btn_Container
            // 
            Btn_Container.Animated = true;
            Btn_Container.AnimatedGIF = true;
            Btn_Container.BorderRadius = 5;
            Btn_Container.CheckedState.FillColor = Color.RoyalBlue;
            Btn_Container.CheckedState.ForeColor = Color.White;
            Btn_Container.CustomizableEdges = customizableEdges1;
            Btn_Container.DefaultAutoSize = true;
            Btn_Container.FillColor = Color.Transparent;
            Btn_Container.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Container.ForeColor = Color.Black;
            Btn_Container.HoverState.FillColor = Color.Transparent;
            Btn_Container.ImageAlign = HorizontalAlignment.Left;
            Btn_Container.ImageSize = new Size(10, 10);
            Btn_Container.Location = new Point(0, 0);
            Btn_Container.Margin = new Padding(0);
            Btn_Container.Name = "Btn_Container";
            Btn_Container.Padding = new Padding(0, 2, 0, 2);
            Btn_Container.PressedColor = Color.RoyalBlue;
            Btn_Container.PressedDepth = 100;
            Btn_Container.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Btn_Container.Size = new Size(65, 32);
            Btn_Container.TabIndex = 11;
            Btn_Container.Text = "Tất cả";
            // 
            // PaginatorButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(Btn_Container);
            Name = "PaginatorButton";
            Size = new Size(65, 32);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Btn_Container;
    }
}
