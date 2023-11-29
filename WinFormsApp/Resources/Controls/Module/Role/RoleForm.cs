using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Resources.Controls.Module.Role;

namespace WinFormsApp.Resources.Controls.Module.Role
{
    public partial class RoleForm : Form
    {
        private readonly IRoleService _RoleService;

        Domain.Entities.Role formData = new Domain.Entities.Role();

        public RoleForm()
        {
            InitializeComponent();

            _RoleService = Program.container.GetInstance<IRoleService>();

            DesktopLocation = new Point((Screen.PrimaryScreen.Bounds.Width - Width), 0);
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        public RoleForm(Domain.Entities.Role formData)
        {
            InitializeComponent();

            _RoleService = Program.container.GetInstance<IRoleService>();

            this.formData = formData;

            LoadData();
        }

        public void LoadData()
        {
            ClearForm();

            //Text_InternalCode.Text = formData.Name;
            //Text_Name.Text = formData.Name;
            //ComboBox_Gender.Text = formData.Sex;
            //DateTime_Birthday.Text = formData.Birthday.ToString();
            //Text_Phone.Text = formData.Phone;

            Label_Heading.Text = "Cập nhập nhân viên " + formData.Name;
        }

        private void ClearForm()
        {
            Text_InternalCode.Clear();
            Text_Name.Clear();
            DateTime_Birthday.Value = DateTime.Now;
            Text_Phone.Clear();
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            //formData.InternalCode = Text_InternalCode.Text;
            //formData.Name = Text_Name.Text;
            //formData.Sex = ComboBox_Gender.Text;
            //formData.Birthday = DateTime_Birthday.Value;
            //formData.Phone = Text_Phone.Text;

            //try
            //{
            //    if (formData.Id != 0)
            //    {
            //        await _RoleService.Update(formData);
            //    }
            //    else
            //    {
            //        await _RoleService.Create(formData);
            //    }

            //    RoleControl._refreshButton.PerformClick();

            //    Close();
            //}
            //catch (Exception err)
            //{
            //    Dialog_Notification.Show(err.Message);
            //}
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
