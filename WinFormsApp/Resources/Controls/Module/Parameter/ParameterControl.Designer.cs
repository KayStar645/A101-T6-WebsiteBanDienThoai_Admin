﻿namespace WinFormsApp.Resources.Controls.Module.Parameter
{
    partial class ParameterControl
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Guna2MessageDialog Dialog_Notification;
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Timer_Debounce = new System.Windows.Forms.Timer(components);
            Dialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            TableLayoutPanel_Header = new TableLayoutPanel();
            Text_Search = new Guna.UI2.WinForms.Guna2TextBox();
            TableLayoutPanel_Action = new TableLayoutPanel();
            Button_Create = new Guna.UI2.WinForms.Guna2Button();
            Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            TableLayoutPanel_Paginator = new TableLayoutPanel();
            Panel_Container = new Panel();
            Dialog_Notification = new Guna.UI2.WinForms.Guna2MessageDialog();
            TableLayoutPanel_Header.SuspendLayout();
            TableLayoutPanel_Action.SuspendLayout();
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
            // Timer_Debounce
            // 
            Timer_Debounce.Interval = 600;
            Timer_Debounce.Tick += Timer_Debounce_Tick;
            // 
            // Dialog_Confirm
            // 
            Dialog_Confirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            Dialog_Confirm.Caption = "Thông báo";
            Dialog_Confirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            Dialog_Confirm.Parent = null;
            Dialog_Confirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            Dialog_Confirm.Text = "Bạn có chắc chắn muốn xóa chứ ?";
            // 
            // TableLayoutPanel_Header
            // 
            TableLayoutPanel_Header.ColumnCount = 2;
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.Controls.Add(Text_Search, 0, 0);
            TableLayoutPanel_Header.Controls.Add(TableLayoutPanel_Action, 1, 0);
            TableLayoutPanel_Header.Dock = DockStyle.Top;
            TableLayoutPanel_Header.Location = new Point(0, 0);
            TableLayoutPanel_Header.Margin = new Padding(0);
            TableLayoutPanel_Header.Name = "TableLayoutPanel_Header";
            TableLayoutPanel_Header.RowCount = 1;
            TableLayoutPanel_Header.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Header.Size = new Size(1161, 67);
            TableLayoutPanel_Header.TabIndex = 0;
            // 
            // Text_Search
            // 
            Text_Search.Anchor = AnchorStyles.Left;
            Text_Search.Animated = true;
            Text_Search.BorderRadius = 8;
            Text_Search.CustomizableEdges = customizableEdges1;
            Text_Search.DefaultText = "";
            Text_Search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Text_Search.ForeColor = Color.Black;
            Text_Search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Search.Location = new Point(0, 7);
            Text_Search.Margin = new Padding(0);
            Text_Search.Name = "Text_Search";
            Text_Search.PasswordChar = '\0';
            Text_Search.PlaceholderText = "Tìm kiếm...";
            Text_Search.SelectedText = "";
            Text_Search.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_Search.Size = new Size(267, 53);
            Text_Search.TabIndex = 2;
            Text_Search.TextChanged += Text_Search_TextChanged;
            // 
            // TableLayoutPanel_Action
            // 
            TableLayoutPanel_Action.ColumnCount = 3;
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            TableLayoutPanel_Action.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            TableLayoutPanel_Action.Controls.Add(Button_Create, 1, 0);
            TableLayoutPanel_Action.Controls.Add(Button_Refresh, 2, 0);
            TableLayoutPanel_Action.Dock = DockStyle.Fill;
            TableLayoutPanel_Action.Location = new Point(580, 0);
            TableLayoutPanel_Action.Margin = new Padding(0);
            TableLayoutPanel_Action.Name = "TableLayoutPanel_Action";
            TableLayoutPanel_Action.RowCount = 1;
            TableLayoutPanel_Action.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Action.Size = new Size(581, 67);
            TableLayoutPanel_Action.TabIndex = 1;
            // 
            // Button_Create
            // 
            Button_Create.Anchor = AnchorStyles.Right;
            Button_Create.AnimatedGIF = true;
            Button_Create.BorderRadius = 8;
            Button_Create.CustomizableEdges = customizableEdges3;
            Button_Create.DisabledState.BorderColor = Color.DarkGray;
            Button_Create.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Create.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Create.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Create.FillColor = Color.FromArgb(100, 88, 255);
            Button_Create.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Create.ForeColor = Color.White;
            Button_Create.Location = new Point(364, 7);
            Button_Create.Margin = new Padding(0);
            Button_Create.Name = "Button_Create";
            Button_Create.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Create.Size = new Size(103, 53);
            Button_Create.TabIndex = 0;
            Button_Create.Text = "Thêm mới";
            Button_Create.Click += Button_Create_Click;
            // 
            // Button_Refresh
            // 
            Button_Refresh.Anchor = AnchorStyles.Right;
            Button_Refresh.AnimatedGIF = true;
            Button_Refresh.BorderRadius = 8;
            Button_Refresh.CustomizableEdges = customizableEdges5;
            Button_Refresh.DisabledState.BorderColor = Color.DarkGray;
            Button_Refresh.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Refresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Refresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Refresh.FillColor = Color.Green;
            Button_Refresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Refresh.ForeColor = Color.White;
            Button_Refresh.Location = new Point(478, 7);
            Button_Refresh.Margin = new Padding(0);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Button_Refresh.Size = new Size(103, 53);
            Button_Refresh.TabIndex = 1;
            Button_Refresh.Text = "Làm mới";
            Button_Refresh.Click += Button_Refresh_Click;
            // 
            // TableLayoutPanel_Paginator
            // 
            TableLayoutPanel_Paginator.ColumnCount = 1;
            TableLayoutPanel_Paginator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Paginator.Dock = DockStyle.Bottom;
            TableLayoutPanel_Paginator.Location = new Point(0, 812);
            TableLayoutPanel_Paginator.Margin = new Padding(3, 4, 3, 4);
            TableLayoutPanel_Paginator.Name = "TableLayoutPanel_Paginator";
            TableLayoutPanel_Paginator.RowCount = 1;
            TableLayoutPanel_Paginator.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_Paginator.Size = new Size(1161, 67);
            TableLayoutPanel_Paginator.TabIndex = 1;
            // 
            // Panel_Container
            // 
            Panel_Container.AutoScroll = true;
            Panel_Container.Dock = DockStyle.Fill;
            Panel_Container.Location = new Point(0, 67);
            Panel_Container.Margin = new Padding(3, 4, 3, 4);
            Panel_Container.Name = "Panel_Container";
            Panel_Container.Size = new Size(1161, 745);
            Panel_Container.TabIndex = 5;
            // 
            // ParameterControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel_Container);
            Controls.Add(TableLayoutPanel_Paginator);
            Controls.Add(TableLayoutPanel_Header);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ParameterControl";
            Size = new Size(1161, 879);
            TableLayoutPanel_Header.ResumeLayout(false);
            TableLayoutPanel_Action.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer_Debounce;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Confirm;
        private TableLayoutPanel TableLayoutPanel_Header;
        private Guna.UI2.WinForms.Guna2TextBox Text_Search;
        private TableLayoutPanel TableLayoutPanel_Action;
        private Guna.UI2.WinForms.Guna2Button Button_Create;
        private Guna.UI2.WinForms.Guna2Button Button_Refresh;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog_Notification;
        private TableLayoutPanel TableLayoutPanel_Paginator;
        private Panel Panel_Container;
    }
}
