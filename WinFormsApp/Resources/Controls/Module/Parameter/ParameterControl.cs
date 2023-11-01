using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Parameter
{
    public partial class ParameterControl : UserControl
    {
        public ParameterControl()
        {
            InitializeComponent();
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            ParameterItem item = new("moi");

            Util.AddControl(Panel_Container, item, DockStyle.Top);
        }
    }
}
