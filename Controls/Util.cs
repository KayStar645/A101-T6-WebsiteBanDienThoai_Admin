using Guna.UI2.WinForms;
using System.Data;
using System.Globalization;

namespace WinFormsApp.Services
{
    public static class Util
    {
        public static void LoadControl(Control pBody, Control pControl, DockStyle? dockStyle = DockStyle.Fill)
        {
            pBody.Controls.Clear();

            AddControl(pBody, pControl, (DockStyle)dockStyle!);
        }

        public static void Collapse(bool collapse, Control container)
        {

            if (collapse)
            {
                container.Size = container.MinimumSize;
            }
            else
            {
                container.Size = container.MaximumSize;
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

        public static string AddCommas(long? number, string currency = "đ")
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

        public static void AddCommasOnKeyUp(object sender)
        {
            Guna2TextBox control = (Guna2TextBox)sender!;

            if (control?.Text == string.Empty)
            {
                return;
            }

            try
            {
                long number = long.Parse(DeleteCommas(control.Text), NumberStyles.AllowThousands);
                control.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0}", number);
                control.Select(control.Text.Length, 0);
            }
            catch (Exception)
            {
            }
        }

        public static DateTime GetDateItemFromGunaData(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;

            string nDate = year + "-" + month + "-" + day;

            return DateTime.Parse(nDate);
        }

        public static void AddControl(Control parent, Control chil, DockStyle dockStyle)
        {
            chil.Dock = dockStyle;
            parent.Controls.Add(chil);
        }

        public static void RemoveChildFrom(Control parent, int from)
        {
            int length = parent.Controls.Count - from;

            for (int i = 0; i < length; i++)
            {
                parent.Controls.RemoveAt(0);
            }
        }

        public static bool CheckControlPermission(Control control, List<string> permissions)
        {
            if(control.Tag == null)
            {
                return false;
            }

            string[] tags = control.Tag.ToString()!.Split("|");

            if (tags.Length < 1)
            {
                return true;
            }

            if (tags[0] != null && tags[0] == "parent")
            {
                string[] childPermissions = tags[1].Split(",");
                int count = 0;

                foreach (var item in childPermissions)
                {

                    if (permissions.Contains(item))
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    return false;
                }
            }
            else if (tags.Length > 1 && tags[1] != null)
            {
                if (!permissions.Contains(tags[1]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckPermission(string perrmission, List<string> permissions)
        {
            return permissions.Contains(perrmission);
        }
    }
}
