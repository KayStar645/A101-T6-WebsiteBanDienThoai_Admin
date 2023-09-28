using Guna.UI2.WinForms;

namespace Services
{
    public static class Util
    {
        public static void LoadControl(Control pBody, Control pControl)
        {
            pBody.Controls.Clear();

            pControl.Dock = DockStyle.Fill;

            pBody.Controls.Add(pControl);
        }

        public static void Scroll(bool isScroll, Guna2Panel container)
        {

            if (!isScroll)
            {
                container.Size = container.MaximumSize;
            }
            else
            {
                container.Size = container.MinimumSize;
            }
        }

        public static void LoadForm(Form form)
        {
            form.Show();
        }
    }
}
