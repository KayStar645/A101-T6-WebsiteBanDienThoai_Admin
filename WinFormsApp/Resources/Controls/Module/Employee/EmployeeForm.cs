using Domain.DTOs;
using Services.Interfaces;

namespace WinFormsApp.Resources.Controls.Module.Employee
{
    public partial class EmployeeForm : Form
    {
        private readonly IEmployeeService _employeeService;

        EmployeeDto formData = new EmployeeDto();

        public EmployeeForm()
        {
            InitializeComponent();

            _employeeService = Program.container.GetInstance<IEmployeeService>();
        }

        public EmployeeForm(EmployeeDto formData)
        {
            InitializeComponent();

            _employeeService = Program.container.GetInstance<IEmployeeService>();

            this.formData = formData;

            this.LoadData();
        }

        public void LoadData()
        {
            ClearForm();

            Text_InternalCode.Text = formData.InternalCode;
            Text_Name.Text = formData.Name;
            cbb_Sex.Text = formData.Sex;
            DateTime_Birthday.Text = formData.Birthday.ToString();
            Text_Phone.Text = formData.Phone;
        }

        private void ClearForm()
        {
            Text_InternalCode.Clear();
            Text_Name.Clear();
            //cbb_Sex.Clear();
            DateTime_Birthday.Value = DateTime.Now;
            Text_Phone.Clear();
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            formData.InternalCode = Text_InternalCode.Text;
            formData.Name = Text_Name.Text;
            formData.Sex = cbb_Sex.Text;
            formData.Birthday = DateTime_Birthday.Value;
            formData.Phone = Text_Phone.Text;

            if (formData.Id != 0)
            {
                await _employeeService.Update(formData);
            }
            else
            {
                await _employeeService.Create(formData);
            }

            EmployeeControl._refreshButton.PerformClick();

            Close();
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
