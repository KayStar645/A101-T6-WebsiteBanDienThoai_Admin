using Domain.DTOs;
using Guna.Charts.WinForms;
using Services.Interfaces;
using System.Windows.Forms;

namespace WinFormsApp.Resources.Controls.Module.Product
{
    public partial class ProductParamDetailForm : Form
    {
        IDetailSpecificationsService _detailSpecificationsService;
        List<ProductParametersDto> _productParameter;
        int _parentId = 0;
        int _index = 0;

        public delegate void OnSave(int index, List<ProductParametersDto> productParams);
        OnSave onSaveCallback;

        public ProductParamDetailForm(string title, int parentId, int index, OnSave onSave)
        {
            InitializeComponent();

            _detailSpecificationsService = Program.container.GetInstance<IDetailSpecificationsService>();
            _parentId = parentId;
            _index = index;
            onSaveCallback = onSave;
            _productParameter = new List<ProductParametersDto>();

            LoadData();

            Label_Heading.Text = "Thông số kỹ thuật: " + title;
        }

        public ProductParamDetailForm(List<ProductParametersDto> productParameters, string title, int parentId, int index, OnSave onSave)
        {
            InitializeComponent();

            _detailSpecificationsService = Program.container.GetInstance<IDetailSpecificationsService>();
            _parentId = parentId;
            _index = index;
            onSaveCallback = onSave;
            _productParameter = productParameters;

            LoadData();

            Label_Heading.Text = "Thông số kỹ thuật: " + title;
        }

        public async void LoadData()
        {
            var result = await _detailSpecificationsService.GetListBySpecificationsIdAsync(_parentId);

            DataGridView_Parameter.DataSource = result;

            if (_productParameter.Count > 0)
            {
                foreach (DataGridViewRow item in DataGridView_Parameter.Rows)
                {
                    int detailSpecificationId = int.Parse(item.Cells["DetailSpecification_Id"].Value.ToString()!);
                    var found = _productParameter.Find(t => t.DetailSpecificationsId == detailSpecificationId);

                    if (found == null)
                    {
                        continue;
                    }

                    item.Cells["Select"].Value = "True";
                }
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            onSaveCallback(_index, _productParameter);

            Close();
        }

        private void DataGridView_Parameter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataGridView_Parameter.CurrentRow;
            bool choose = bool.Parse(row.Cells["Select"].FormattedValue.ToString()!);
            int detailSpecificationId = int.Parse(row.Cells["DetailSpecification_Id"].Value.ToString()!);

            if (choose)
            {
                row.Cells["Select"].Value = "False";

                var i = _productParameter.FindIndex(t => t.DetailSpecificationsId == detailSpecificationId);


                if (i > -1)
                {
                    _productParameter.RemoveAt(i);
                }
            }
            else
            {
                row.Cells["Select"].Value = "True";

                _productParameter.Add(new ProductParametersDto()
                {
                    DetailSpecificationsId = detailSpecificationId,
                });
            }
        }
    }
}
