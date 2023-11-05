using Domain.DTOs;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Services.Interfaces;
using WinFormsApp.Resources.Controls.Module.Configuration;
using WinFormsApp.Resources.Controls.Module.Distributor;
using WinFormsApp.Resources.Controls.Module.Employee;
using WinFormsApp.Resources.Controls.Module.Import;
using WinFormsApp.Resources.Controls.Module.Parameter;
using WinFormsApp.Resources.Controls.Module.Product;
using WinFormsApp.Resources.Controls.Module.Promotion;
using WinFormsApp.Services;

namespace WinFormsApp.View.Screen
{
    public partial class Admin : Form
    {
        string _currPanel;
        public static Button _refreshCategoryBtn = new();

        public Admin()
        {
            InitializeComponent();

            LoadCategory();

            Util.LoadControl(Panel_Body, new DistributorControl());

            _refreshCategoryBtn.Click += _refreshCategoryBtn_Click;
        }

        private void _refreshCategoryBtn_Click(object? sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadMenu()
        {
            var masterDataControls = Panel_MaterData.Controls;
            var productControls = Panel_Product.Controls;
            var systemControls = Panel_System.Controls;
            var businessControls = Panel_Business.Controls;

            if (_currPanel != "panel_masterData")
            {
                for (int i = 0; i < masterDataControls.Count; i++)
                {
                    Guna2Button btn = (Guna2Button)masterDataControls[i];

                    if (btn.Tag!.ToString()!.Split("|")[0] != "parent")
                    {
                        btn.Checked = false;
                    }
                }
            }

            if (_currPanel != "panel_product")
            {
                for (int i = 0; i < productControls.Count; i++)
                {
                    Guna2Button btn = (Guna2Button)productControls[i];

                    if (btn.Tag!.ToString()!.Split("|")[0] != "parent")
                    {
                        btn.Checked = false;
                    }
                }
            }

            if (_currPanel != "panel_system")
            {
                for (int i = 0; i < systemControls.Count; i++)
                {
                    Guna2Button btn = (Guna2Button)systemControls[i];

                    if (btn.Tag!.ToString()!.Split("|")[0] != "parent")
                    {
                        btn.Checked = false;
                    }
                }
            }

            if (_currPanel != "panel_business")
            {
                for (int i = 0; i < businessControls.Count; i++)
                {
                    Guna2Button btn = (Guna2Button)businessControls[i];

                    if (btn.Tag!.ToString()!.Split("|")[0] != "parent")
                    {
                        btn.Checked = false;
                    }
                }
            }

            if (_currPanel == "panel_masterData")
            {
                Btn_MasterData.Checked = true;
            }

            if (_currPanel == "panel_product")
            {
                Btn_Product.Checked = true;
            }

            if (_currPanel == "panel_system")
            {
                Btn_System.Checked = true;
            }

            if (_currPanel == "panel_business")
            {
                Btn_Business.Checked = true;
            }
        }

        private void Btn_MasterData_Click(object sender, EventArgs e)
        {
            Util.Collpase(!Btn_MasterData.Checked, Panel_MaterData);
        }

        private void Btn_Product_Click(object sender, EventArgs e)
        {
            Util.Collpase(!Btn_Product.Checked, Panel_Product);
        }

        private void Btn_System_Click(object sender, EventArgs e)
        {
            Util.Collpase(!Btn_System.Checked, Panel_System);
        }

        private void Btn_Business_Click(object sender, EventArgs e)
        {
            Util.Collpase(!Btn_Business.Checked, Panel_Business);
        }

        private void Btn_Distributor_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách nhà cung cấp";
            Util.LoadControl(Panel_Body, new DistributorControl());

            _currPanel = Btn_Distributor.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }

        private void Btn_Promotion_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách chương trình khuyến mãi";
            Util.LoadControl(Panel_Body, new PromotionControl());

            _currPanel = Btn_Promotion.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách đơn hàng";

            _currPanel = Btn_Order.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách nhân viên";
            Util.LoadControl(Panel_Body, new EmployeeControl());

            _currPanel = Btn_Employee.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Danh sách khách hàng";

            _currPanel = Btn_Customer.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }

        private void Btn_Configuration_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Cấu hình chung";
            Util.LoadControl(Panel_Body, new ConfigurationControl());

            _currPanel = Btn_Configuration.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }

        public async void LoadCategory()
        {
            ICategoryService _categoryService = Program.container.GetInstance<ICategoryService>();
            var _result = await _categoryService.GetList();

            Util.RemoveChildFrom(Panel_Product, 1);

            Util.Collpase(true, Panel_Product);

            foreach (var item in _result.list)
            {
                Guna2Button btn = CategoryButton(item);

                Util.AddControl(Panel_Product, btn, DockStyle.Top);

                int panelHeight = Panel_Product.Height + 40;

                Panel_Product.MaximumSize = new Size(248, panelHeight);
                Panel_Product.Height = panelHeight;
            }

            Btn_Product.SendToBack();
        }

        private Guna2Button CategoryButton(CategoryDto category)
        {
            Guna2Button btn = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            btn.Cursor = Cursors.Hand;
            btn.Animated = true;
            btn.AnimatedGIF = true;
            btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn.CheckedState.FillColor = Color.RoyalBlue;
            btn.CheckedState.ForeColor = Color.White;
            btn.CustomizableEdges = edge1;
            btn.DisabledState.BorderColor = Color.Transparent;
            btn.DisabledState.CustomBorderColor = Color.Transparent;
            btn.DisabledState.FillColor = Color.Transparent;
            btn.DisabledState.ForeColor = Color.Transparent;
            btn.FillColor = Color.Transparent;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn.ForeColor = Color.Black;
            btn.HoverState.FillColor = Color.Transparent;
            btn.ImageAlign = HorizontalAlignment.Left;
            btn.ImageSize = new Size(10, 10);
            btn.Location = new Point(0, 40);
            btn.Margin = new Padding(0);
            btn.Name = "Btn_Phone";
            btn.Padding = new Padding(26, 0, 0, 0);
            btn.PressedColor = Color.RoyalBlue;
            btn.PressedDepth = 100;
            btn.ShadowDecoration.CustomizableEdges = edge2;
            btn.Size = new Size(248, 40);
            btn.TabIndex = 15;
            btn.Tag = "panel_product" + "|" + category.Name + "|" + category.Id;
            btn.Text = category.Name;
            btn.BorderRadius = 8;
            btn.TextAlign = HorizontalAlignment.Left;
            btn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            btn.Click += Btn_Category_Click!;
            btn.HoverState.FillColor = Color.WhiteSmoke;

            return btn;
        }

        private async void Btn_Category_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            CategoryDto category = new()
            {
                Id = int.Parse(btn.Tag!.ToString()!.Split("|")[2]),
                Name = btn.Tag!.ToString()!.Split("|")[1]
            };

            Label_Heading.Text = "Danh sách " + category.Name;
            Util.LoadControl(Panel_Body, new ProductControl(category));

            _currPanel = btn.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }

        private void Btn_Parameter_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Thông số kỹ thuật";
            Util.LoadControl(Panel_Body, new ParameterControl());

            _currPanel = Btn_Parameter.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            Label_Heading.Text = "Nhập hàng";
            Util.LoadControl(Panel_Body, new ImportControl());

            _currPanel = Btn_Import.Tag!.ToString()!.Split("|")[0];
            LoadMenu();
        }
    }
}
