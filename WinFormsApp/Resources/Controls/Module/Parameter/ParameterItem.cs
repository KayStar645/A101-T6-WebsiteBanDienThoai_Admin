using Domain.DTOs;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Parameter
{
    public partial class ParameterItem : UserControl
    {
        bool collapse = false;
        ISpecificationsService _specificationsService;
        IDetailSpecificationsService _detailSpecificationsService;
        List<DetailSpecificationsDto> _details;
        int _parentId = 0;
        int _childKey = new Random().Next(9999);

        public ParameterItem(string title, int id)
        {
            InitializeComponent();

            _specificationsService = Program.container.GetInstance<ISpecificationsService>();
            _detailSpecificationsService = Program.container.GetInstance<IDetailSpecificationsService>();

            _parentId = id;

            Text_Parent.Text = title;
        }

        public ParameterItem(string title)
        {
            InitializeComponent();

            _specificationsService = Program.container.GetInstance<ISpecificationsService>();
            _detailSpecificationsService = Program.container.GetInstance<IDetailSpecificationsService>();

            Text_Parent.Text = title;
        }

        private void ImageButton_Chevron_Click(object sender, EventArgs e)
        {
            Util.Scroll(collapse, this);

            collapse = !collapse;

            LoadDetail(_parentId);
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            TableLayoutPanel parent = (TableLayoutPanel)btn.Parent!;
            Guna2TextBox name = (Guna2TextBox)parent.Controls[2];
            Guna2TextBox value = (Guna2TextBox)parent.Controls[1];
            SpecificationsDto formData = new()
            {
                Name = name.Text,
            };

            if (_parentId > 0)
            {
                SpecificationsDto specifications = _specificationsService.Create();
            }
            else
            {

            }
        }

        private async void LoadDetail(int specificationsId)
        {
            _details = await _detailSpecificationsService.GetListBySpecificationsIdAsync(specificationsId);

            foreach (var item in _details)
            {
                Util.AddControl(this, Child(), DockStyle.Top);
            }
        }

        private TableLayoutPanel Child()
        {
            TableLayoutPanel child = new();

            child.ColumnCount = 3;
            child.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            child.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            child.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            child.Controls.Add(ChildBtn(_childKey), 0, 0);
            child.Controls.Add(ChildName(_childKey), 0, 0);
            child.Controls.Add(Childvalue(_childKey), 0, 0);
            child.Location = new Point(0, 52);
            child.Margin = new Padding(3, 8, 3, 3);
            child.Name = "TableLayoutPanel_Container" + _childKey;
            child.Padding = new Padding(0, 8, 0, 0);
            child.RowCount = 1;
            child.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            child.Size = new Size(0, 50);
            child.TabIndex = 6;

            return child;
        }

        private Guna2TextBox ChildName(int key)
        {
            Guna2TextBox name = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            name.CustomizableEdges = edge1;
            name.DefaultText = "";
            name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            name.Dock = DockStyle.Fill;
            name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            name.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            name.Location = new Point(3, 11);
            name.Name = "Text_Name" + key;
            name.PasswordChar = '\0';
            name.PlaceholderText = "Tên thông số";
            name.SelectedText = "";
            name.ShadowDecoration.CustomizableEdges = edge2;
            name.Size = new Size(192, 36);
            name.TabIndex = 0;

            return name;
        }

        private Guna2TextBox Childvalue(int key)
        {
            Guna2TextBox value = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            value.CustomizableEdges = edge1;
            value.DefaultText = "";
            value.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            value.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            value.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            value.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            value.Dock = DockStyle.Fill;
            value.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            value.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            value.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            value.Location = new Point(210, 11);
            value.Margin = new Padding(12, 3, 3, 3);
            value.Name = "Text_Value" + key;
            value.PasswordChar = '\0';
            value.PlaceholderText = "Giá trị thông số";
            value.SelectedText = "";
            value.ShadowDecoration.CustomizableEdges = edge2;
            value.Size = new Size(282, 36);
            value.TabIndex = 1;

            return value;
        }

        private Guna2Button ChildBtn(int key)
        {
            Guna2Button btn = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            btn.AnimatedGIF = true;
            btn.BorderRadius = 8;
            btn.CustomizableEdges = edge1;
            btn.DisabledState.BorderColor = Color.DarkGray;
            btn.DisabledState.CustomBorderColor = Color.DarkGray;
            btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn.Dock = DockStyle.Fill;
            btn.FillColor = Color.FromArgb(100, 88, 255);
            btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn.ForeColor = Color.White;
            btn.Location = new Point(498, 11);
            btn.Name = "Btn_Create" + key;
            btn.ShadowDecoration.CustomizableEdges = edge2;
            btn.Size = new Size(85, 36);
            btn.TabIndex = 2;
            btn.Text = "Thêm mới";
            btn.Click += Button_Create_Click;

            return btn;
        }
    }
}
