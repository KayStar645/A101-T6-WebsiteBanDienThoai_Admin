using Domain.ModelViews;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Import
{
    public partial class ImportDetailControl : UserControl
    {
        List<ProductVM> _products;

        public ImportDetailControl(int id)
        {
            InitializeComponent();
        }

        public ImportDetailControl()
        {
            InitializeComponent();

            _products = new List<ProductVM>();
        }

        private void Button_AddProduct_Click(object sender, EventArgs e)
        {
            if(_products.Count > 0)
            {
                Util.LoadForm(new ImportProductControl(OnSaveProduct, _products), true);

            }
            else
            {
                Util.LoadForm(new ImportProductControl(OnSaveProduct), true);
            }
        }

        private void OnSaveProduct(List<ProductVM> products)
        {
            _products = products;

            LoadData();
        }

        private void LoadData()
        {
            DataGridView_Product.DataSource = _products;

            foreach (DataGridViewRow item in DataGridView_Product.Rows)
            {
                item.Cells["Product_Select"].Value = true;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new ImportControl());
        }
    }
}
