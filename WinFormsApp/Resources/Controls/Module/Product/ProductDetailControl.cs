using Controls.Type;
using Domain.DTOs;
using Domain.Entities;
using Domain.ModelViews;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Product
{
    public partial class ProductDetailControl : UserControl
    {
        DetailProductVM _product;

        ISpecificationsService _specificationsService;
        IProductService _productService;
        IProductParametersService _productParameterService;
        ICapacityService _capacityService;
        IColorService _colorService;
        List<ProductParameter> _productParameters;

        public ProductDetailControl(CategoryDto category)
        {
            InitializeComponent();

            _product = new()
            {
                CapacityId = 0,
                CategoryId = category.Id,
                ColorId = 0,
                Id = 0,
                Price = 0,
                Images = new List<string>(),
                CategoryName = category.Name,
            };

            OnInit();
        }

        public ProductDetailControl(int productId)
        {
            InitializeComponent();

            _product = new()
            {
                Id = productId,
            };

            OnInit();
        }

        private async void OnInit()
        {
            _productParameters = new List<ProductParameter>();
            _specificationsService = Program.container.GetInstance<ISpecificationsService>();
            _productService = Program.container.GetInstance<IProductService>();
            _productParameterService = Program.container.GetInstance<IProductParametersService>();
            _capacityService = Program.container.GetInstance<ICapacityService>();
            _colorService = Program.container.GetInstance<IColorService>();

            await LoadCapacity();
            await LoadColor();

            Label_Heading.Text = "Thêm mới sản phẩm";

            if (_product.Id != 0)
            {
                var result = await _productService.GetDetail(_product.Id);

                _product = result;
                Label_Heading.Text = "Cập nhập" + _product.Name;

                LoadInfo();
                LoadImage();

                ComboBox_Color.SelectedValue = _product.ColorId;
                ComboBox_Capacity.SelectedValue = _product.CapacityId;
            }

            await LoadParameter();
        }

        private void LoadInfo()
        {
            Text_Name.Text = _product.Name;
            Text_InternalCode.Text = _product.InternalCode;
            Text_Price.Text = Util.AddCommas(_product.Price);
        }

        private async Task LoadCapacity()
        {
            var result = await _capacityService.GetList();
            var list = result.list;

            ComboBox_Capacity.Sorted = false;
            ComboBox_Capacity.DataSource = list;
            ComboBox_Capacity.ValueMember = "Id";
            ComboBox_Capacity.DisplayMember = "Name";
            ComboBox_Capacity.SelectedIndex = -1;
        }

        private async Task LoadColor()
        {
            var result = await _colorService.GetList();
            var list = result.list;

            ComboBox_Color.Sorted = false;
            ComboBox_Color.DataSource = list;
            ComboBox_Color.ValueMember = "Id";
            ComboBox_Color.DisplayMember = "Name";
            ComboBox_Color.SelectedIndex = -1;
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string price = Util.DeleteCommas(Text_Price.Text);

                ProductDto product = new()
                {
                    Id = _product.Id,
                    Name = Text_Name.Text,
                    InternalCode = Text_InternalCode.Text,
                    Price = long.Parse(string.IsNullOrEmpty(price) ? "0" : price),
                    CapacityId = int.Parse(ComboBox_Capacity.SelectedValue?.ToString() ?? "0"),
                    ColorId = int.Parse(ComboBox_Color.SelectedValue?.ToString() ?? "0"),
                    Quantity = 0,
                    CategoryId = _product.CategoryId,
                    Images = _product.Images,
                };

                if (_product.Id == 0)
                {
                    int productId = await _productService.Create(product);

                    if (productId == 0)
                    {
                        return;
                    }

                    List<ProductParametersDto> productParameters = _productParameters.SelectMany(t => t.productParameters!).ToList();

                    foreach (var item in productParameters)
                    {
                        item.ProductId = productId;

                        await _productParameterService.Create(item);
                    }
                }
                else
                {
                    await _productService.Update(product);

                    List<ProductParametersDto> productParameters = _productParameters.SelectMany(t => t.productParameters!).ToList();

                    foreach (var item in productParameters)
                    {
                        item.ProductId = _product.Id;

                        await _productParameterService.Create(item);
                    }
                }

                Util.LoadControl(this, new ProductControl(new CategoryDto()
                {
                    Id = (int)_product.CategoryId!,
                    Name = _product.CategoryName
                }));
            }
            catch (Exception ex)
            {
                Dialog_Notification.Show(ex.Message);
            }

        }

        /*========================================= PARAMETER =============================================*/

        private async Task LoadParameter()
        {
            var result = await _specificationsService.GetList();
            List<SpecificationsDto> specificationsDtos = result.list;

            for (int i = 0; i < specificationsDtos.Count; i++)
            {
                var item = specificationsDtos[i];
                List<ProductParametersDto> list = new();

                Panel_Parameter.Controls.Add(ParameterButton(item.Name!, item.Id, i));

                if (_product.Id > 0)
                {
                    foreach (var specifications in _product.SpecificationsDtos)
                    {
                        if (item.Id != specifications.Id)
                        {
                            continue;
                        }

                        foreach (var detailSpecifications in specifications.Details)
                        {
                            list.Add(new ProductParametersDto()
                            {
                                DetailSpecificationsId = detailSpecifications.Id,
                                ProductId = _product.Id,
                            });
                        }
                    }
                }

                _productParameters.Add(new ProductParameter()
                {
                    productParameters = list
                });
            }
        }

        private Guna2Button ParameterButton(string text, int parameterId, int index)
        {
            Guna2Button btn = new();
            CustomizableEdges edge = new();

            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btn.Dock = DockStyle.Top;
            btn.FillColor = System.Drawing.Color.Transparent;
            btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn.ForeColor = System.Drawing.Color.Black;
            btn.Image = Properties.Resources.arrow_right;
            btn.ImageAlign = HorizontalAlignment.Right;
            btn.ImageSize = new Size(16, 16);
            btn.Location = new Point(0, 0);
            btn.ShadowDecoration.CustomizableEdges = edge;
            btn.Size = new Size(986, 45);
            btn.TabIndex = 0;
            btn.Text = text;
            btn.Tag = parameterId + "|" + index;
            btn.TextAlign = HorizontalAlignment.Left;
            btn.Click += Btn_DetailParameter_Click;

            return btn;
        }

        private void Btn_DetailParameter_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            string[] tags = btn.Tag!.ToString()!.Split("|");
            int parentId = int.Parse(tags[0]);
            int index = int.Parse(tags[1]);

            if (_productParameters.Count == 0)
            {
                Util.LoadForm(new ProductParamDetailForm(btn.Text, parentId, index, OnSaveParameters), true);
            }
            else
            {
                Util.LoadForm(new ProductParamDetailForm(_productParameters[index].productParameters!, btn.Text, parentId, index, OnSaveParameters), true);
            }
        }

        private void OnSaveParameters(int index, List<ProductParametersDto> productParameters)
        {
            _productParameters[index].productParameters = productParameters;
        }

        /*========================================= IMAGE =============================================*/

        private void LoadImage()
        {
            foreach (var item in (_product.Images ?? new List<string>()))
            {
                Panel_Images.Controls.Add(ProductImageBlock(item));
            }
        }

        private Panel ProductImageBlock(string url)
        {
            Panel panel = new();

            panel.Controls.Add(ProductImage(url));
            panel.Dock = DockStyle.Left;
            panel.Location = new Point(0, 0);
            panel.Padding = new Padding(0, 0, 12, 0);
            panel.Size = new Size(141, 167);
            panel.TabIndex = 0;

            return panel;
        }

        private PictureBox ProductImage(string url)
        {
            PictureBox pictureBox = new();

            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(3, 3, 12, 3);
            pictureBox.Padding = new Padding(0, 0, 12, 0);
            pictureBox.Size = new Size(135, 170);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            try
            {
                pictureBox.Load(url);
            }
            catch (Exception)
            {
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            return pictureBox;
        }

        private void Btn_Image_Click(object sender, EventArgs e)
        {
            if (_product.Images!.Count > 0)
            {
                Util.LoadForm(new ProductImageForm(_product.Images, OnSaveImage), true);
            }
            else
            {
                Util.LoadForm(new ProductImageForm(OnSaveImage), true);
            }
        }

        private void OnSaveImage(List<string> images)
        {
            _product.Images = images;

            LoadImage();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new ProductControl(new CategoryDto()
            {
                Id = (int)_product.CategoryId!,
                Name = _product.CategoryName
            }));
        }

        private void ComboBox_Capacity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
