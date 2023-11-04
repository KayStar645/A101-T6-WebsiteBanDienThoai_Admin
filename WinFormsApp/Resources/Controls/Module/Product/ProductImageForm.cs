using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp.Resources.Controls.Module.Product
{
    public partial class ProductImageForm : Form
    {
        public delegate void OnSave(List<string> images);
        OnSave onSaveCallback;

        List<string> _images = new List<string>();

        public ProductImageForm(OnSave onSave)
        {
            InitializeComponent();

            onSaveCallback = onSave;

            DataTable table = new DataTable();
            table.Columns.Add("Đường dẫn");
            DataGridView_Images.DataSource = table;
        }

        public ProductImageForm(List<string> images, OnSave onSave)
        {
            InitializeComponent();

            onSaveCallback = onSave;
            _images = images;

            DataTable table = new DataTable();
            table.Columns.Add("Đường dẫn");
            foreach (string s in _images)
            {
                table.Rows.Add(s);
            }
            DataGridView_Images.DataSource = table;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = DataGridView_Images.Rows;
            string pattern = "[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b([-a-zA-Z0-9()@:%_\\+.~#?&//=]*)?";
            Regex regex = new(pattern);
            bool checkUrl = true;

            foreach (DataGridViewRow item in rows)
            {
                var url = item.Cells[0].Value;

                if (url == null)
                {
                    continue;
                }

                if (!regex.IsMatch(url.ToString()!))
                {
                    checkUrl = false;
                    break;
                }

                _images.Add(url.ToString()!);
            }


            if (checkUrl)
            {
                onSaveCallback(_images);
                Close();
            }
            else
            {
                Dialog_Notification.Show();
            }
        }
    }
}
