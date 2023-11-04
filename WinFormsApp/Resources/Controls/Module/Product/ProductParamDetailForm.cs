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
                    int id = int.Parse(item.Cells["Parameter_Id"].Value.ToString()!);
                    var found = _productParameter.Find(t => t.Id == id);

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
            DataGridViewRowCollection rows = DataGridView_Parameter.Rows;

            _productParameter.Clear();

            foreach (DataGridViewRow item in rows)
            {
                if (item.Cells["Select"].FormattedValue != null && bool.Parse(item.Cells["Select"].FormattedValue.ToString()!))
                {
                    _productParameter.Add(new ProductParametersDto()
                    {
                        Id = int.Parse(item.Cells["Parameter_Id"].Value.ToString()!),
                        DetailSpecificationsId = int.Parse(item.Cells["SpecificationsId"].Value.ToString()!),
                        ProductId = 0
                    });
                }
            }

            onSaveCallback(_index, _productParameter);

            Close();
        }

        private void DataGridView_Parameter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataGridView_Parameter.CurrentRow;
            bool choose = bool.Parse(row.Cells["Select"].FormattedValue.ToString()!);

            if (choose)
            {
                row.Cells["Select"].Value = "False";
            }
            else
            {
                row.Cells["Select"].Value = "True";
            }
        }
    }
}
