namespace WinFormsApp.Resources.Controls.Module.Parameter
{
    public partial class ParameterItem : UserControl
    {
        public ParameterItem(string title)
        {
            InitializeComponent();

            Text_Parent.Text = title;
        }

        private void ImageButton_Chevron_Click(object sender, EventArgs e)
        {

        }
    }
}
