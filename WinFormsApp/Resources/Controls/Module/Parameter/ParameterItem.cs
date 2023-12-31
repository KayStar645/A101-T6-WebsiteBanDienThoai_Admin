﻿using Domain.DTOs;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Parameter
{
    public partial class ParameterItem : UserControl
    {
        bool collapse = true;
        ISpecificationsService _specificationsService;
        IDetailSpecificationsService _detailSpecificationsService;
        List<DetailSpecificationsDto> _details;
        SpecificationsDto _parent;
        SpecificationsDto formData = new();

        public ParameterItem(SpecificationsDto parent)
        {
            InitializeComponent();

            _specificationsService = Program.container.GetInstance<ISpecificationsService>();
            _detailSpecificationsService = Program.container.GetInstance<IDetailSpecificationsService>();

            _parent = parent;

            Text_Parent.Text = parent.Name;
        }

        public ParameterItem()
        {
            InitializeComponent();

            _specificationsService = Program.container.GetInstance<ISpecificationsService>();
            _detailSpecificationsService = Program.container.GetInstance<IDetailSpecificationsService>();

            _parent = new()
            {
                Id = 0
            };
        }

        private void ImageButton_Chevron_Click(object sender, EventArgs e)
        {
            collapse = !collapse;

            if (collapse)
            {
                Util.Collapse(true, this);
            }
            else
            {
                LoadDetail(_parent.Id);
                Util.Collapse(false, this);
            }

            MaximumSize = new Size(0, Height - 70);
            Height -= 70;
        }

        private async void Button_Create_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            TableLayoutPanel parent = (TableLayoutPanel)btn.Parent!;
            Guna2TextBox name = (Guna2TextBox)parent.Controls[2];
            Guna2TextBox value = (Guna2TextBox)parent.Controls[3];

            formData.Name = Text_Parent.Text;

            try
            {
                if (_parent.Id == 0)
                {
                    _parent.Id = await _specificationsService.Create(formData);

                    if (_parent.Id > 0)
                    {
                        DetailSpecificationsDto formChildData = new()
                        {
                            Name = name.Text,
                            Description = value.Text,
                            SpecificationsId = _parent.Id
                        };

                        await _detailSpecificationsService.Create(formChildData);
                    }
                }
                else
                {
                    DetailSpecificationsDto formChildData = new()
                    {
                        Name = name.Text,
                        Description = value.Text,
                        SpecificationsId = _parent.Id
                    };

                    await _detailSpecificationsService.Create(formChildData);

                }

                Util.Collapse(false, this);
                Util.Collapse(true, this);

                LoadDetail(_parent.Id);
            }
            catch (Exception err)
            {
                Dialog_Notification.Show(err.Message);
            }
        }

        private async void Btn_SaveParent_ClickAsync(object sender, EventArgs e)
        {
            formData.Name = Text_Parent.Text;
            formData.Id = _parent.Id;

            try
            {
                if (_parent.Id == 0)
                {
                    await _specificationsService.Create(formData);
                }
                else
                {
                    await _specificationsService.Update(formData);
                }

                ParameterControl._refreshBtn.PerformClick();
            }
            catch (Exception err)
            {
                Dialog_Notification.Show(err.Message);
            }
        }

        private async void LoadDetail(int specificationsId)
        {
            _details = await _detailSpecificationsService.GetListBySpecificationsIdAsync(specificationsId);

            Util.RemoveChildFrom(this, 1);

            for (int i = 0; i < _details.Count; i++)
            {
                var item = _details[i];
                var child = Child(item);

                Util.AddControl(this, child, DockStyle.Top);

                MaximumSize = new Size(0, Height + 50);
                Height += 50;
            }

            MaximumSize = new Size(0, Height + 70);
            Height += 70;

            Util.AddControl(this, Child(null), DockStyle.Top);

            TableLayoutPanel_Header.SendToBack();
        }

        private TableLayoutPanel Child(DetailSpecificationsDto? item)
        {
            TableLayoutPanel child = new();
            DetailSpecificationsDto? nItem = item;

            nItem ??= new()
            {
                Id = 0,
                Description = string.Empty,
                Name = string.Empty,
            };


            child.BackColor = Color.Transparent;
            child.ColumnCount = 4;
            child.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            child.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            child.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            child.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            child.Controls.Add(ChildBtnCreate(), 0, 0);
            child.Controls.Add(ChildBtnRemove(nItem.Id), 0, 0);
            child.Controls.Add(ChildName(nItem.Name), 0, 0);
            child.Controls.Add(Childvalue(nItem.Description), 0, 0);
            child.Dock = DockStyle.Top;
            child.Location = new Point(0, 52);
            child.Margin = new Padding(3, 8, 3, 3);
            child.Padding = new Padding(0, 8, 0, 0);
            child.RowCount = 1;
            child.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            child.Size = new Size(589, 50);
            child.TabIndex = 13;

            return child;
        }

        private Guna2TextBox ChildName(string data)
        {
            Guna2TextBox name = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            name.CustomizableEdges = edge1;
            name.DefaultText = "";
            name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            name.ForeColor = Color.Black;
            name.Dock = DockStyle.Fill;
            name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            name.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            name.Location = new Point(3, 11);
            name.PasswordChar = '\0';
            name.PlaceholderText = "Tên thông số";
            name.SelectedText = "";
            name.Text = data;
            name.ShadowDecoration.CustomizableEdges = edge2;
            name.Size = new Size(204, 36);
            name.TabIndex = 0;
            name.BorderRadius = 5;

            return name;
        }

        private Guna2TextBox Childvalue(string data)
        {
            Guna2TextBox value = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            value.CustomizableEdges = edge1;
            value.DefaultText = "";
            value.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            value.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            value.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            value.ForeColor = Color.Black;
            value.Dock = DockStyle.Fill;
            value.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            value.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            value.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            value.Location = new Point(222, 11);
            value.Margin = new Padding(12, 3, 3, 3);
            value.PasswordChar = '\0';
            value.PlaceholderText = "Giá trị thông số";
            value.SelectedText = "";
            value.Text = data;
            value.ShadowDecoration.CustomizableEdges = edge2;
            value.Size = new Size(300, 36);
            value.TabIndex = 1;
            value.BorderRadius = 5;

            return value;
        }

        private Guna2Button ChildBtnCreate()
        {
            Guna2Button btn = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            btn.Anchor = AnchorStyles.None;
            btn.AnimatedGIF = true;
            btn.BorderRadius = 8;
            btn.CustomizableEdges = edge1;
            btn.DisabledState.BorderColor = Color.DarkGray;
            btn.DisabledState.CustomBorderColor = Color.DarkGray;
            btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn.FillColor = Color.FromArgb(100, 88, 255);
            btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn.ForeColor = Color.White;
            btn.Location = new Point(474, 11);
            btn.ShadowDecoration.CustomizableEdges = edge2;
            btn.Size = new Size(48, 36);
            btn.TabIndex = 3;
            btn.Text = "Lưu";
            btn.Click += Button_Create_Click;


            if (!Util.CheckPermission("Specifications.Update"))
            {
                btn.Enabled = false;
            }

            return btn;
        }

        private Guna2Button ChildBtnRemove(int id)
        {
            Guna2Button btn = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            btn.Anchor = AnchorStyles.None;
            btn.AnimatedGIF = true;
            btn.BorderRadius = 8;
            btn.CustomizableEdges = edge1;
            btn.DisabledState.BorderColor = Color.DarkGray;
            btn.DisabledState.CustomBorderColor = Color.DarkGray;
            btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn.FillColor = Color.Crimson;
            btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn.ForeColor = Color.White;
            btn.Location = new Point(534, 11);
            btn.ShadowDecoration.CustomizableEdges = edge2;
            btn.Size = new Size(48, 36);
            btn.TabIndex = 2;
            btn.Text = "Xóa";
            btn.Click += Btn_ChildRemove_Click;
            btn.Tag = id;

            if (!Util.CheckPermission("Specifications.Delete"))
            {
                btn.Enabled = false;
            }

            return btn;
        }

        private async void Btn_ChildRemove_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            await _detailSpecificationsService.Delete(int.Parse(btn.Tag!.ToString()));

            Util.Collapse(false, this);
            Util.Collapse(true, this);

            LoadDetail(_parent.Id);
        }

        private async void Btn_RemoveParent_Click(object sender, EventArgs e)
        {
            await _specificationsService.Delete(_parent.Id);

            ParameterControl._refreshBtn.PerformClick();
        }
    }
}
