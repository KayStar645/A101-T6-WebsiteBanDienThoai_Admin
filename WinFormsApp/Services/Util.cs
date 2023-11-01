using Guna.UI2.WinForms;
using System.Data;
using System.Globalization;

namespace WinFormsApp.Services
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

            if (isScroll)
            {
                container.Size = container.MaximumSize;
            }
            else
            {
                container.Size = container.MinimumSize;
            }
        }

        public static void LoadForm(Form form, bool isDialog = false)
        {
            if(isDialog)
            {
                form.ShowDialog();
            }
            else
            {
                form.Show();
            }
        }

        public static void IsNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public static string AddCommas(int number, string currency = "đ")
        {
            return (string.Format("{0:n0}", number) + currency).Trim();
        }

        public static string ConvertToTime(int pNumber, int cost)
        {
            int hour = pNumber / cost;
            int minute = (pNumber % cost * 60) / 10000;
            int second = (minute % cost * 60) / 10000;

            return AddZero(hour.ToString()) + ":" + AddZero(minute.ToString()) + ":" + AddZero(second.ToString());
        }

        public static string DeleteCommas(string pStr)
        {
            pStr = pStr.Replace('đ', ' ');
            pStr = pStr.Trim();
            string newStr = "";
            string[] list = pStr.Split(new char[] { '.', ',' });
            foreach (string str in list)
            {
                newStr += str;
            }

            return newStr;
        }

        public static void ResetDialog(Guna2MessageDialog pDialog)
        {
            pDialog.Icon = MessageDialogIcon.Warning;
            pDialog.Buttons = MessageDialogButtons.YesNo;
        }

        public static string AddZero(string pStr)
        {
            int number = int.Parse(pStr);
            string newStr = pStr;
            if (number >= 0 && number <= 9)
            {
                newStr = "0" + pStr;
            }
            return newStr;
        }

        public static void LoadComoboBox(Guna2ComboBox pComboBox, DataTable pSource, string pDisplayMember, int pStartIndex = -1)
        {

            pComboBox.DataSource = pSource;
            pComboBox.DisplayMember = pDisplayMember;
            pComboBox.StartIndex = pStartIndex;
        }

        public static void AddCommasOnKeyUp(object sender)
        {
            Guna2TextBox? control = sender as Guna2TextBox;
            if (control?.Text != string.Empty)
            {
                int number = int.Parse(DeleteCommas(control.Text), NumberStyles.AllowThousands);
                control.Text = string.Format(new CultureInfo("en-US"), "{0:N0}", number);
                control.Select(control.Text.Length, 0);
            }
        }

        public static DateTime GetDateItemFromGunaData(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            int hour = date.Hour;
            int minute = date.Minute;
            int second = date.Second;

            string nDate = year + "-" + month + "-" + day;

            return DateTime.Parse(nDate);
        }
    }
}
