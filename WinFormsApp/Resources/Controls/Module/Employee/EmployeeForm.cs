using Domain.DTOs;
using Services.Interfaces;
using SimpleInjector;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Employee
{
	public partial class EmployeeForm : Form
	{
		private readonly Container _container;
		private readonly IEmployeeService _employeeService;

		EmployeeDto formData = new EmployeeDto();

		public EmployeeForm(Container container)
		{
			_container = container;

			InitializeComponent();

			_employeeService = _container.GetInstance<IEmployeeService>();
		}

		public EmployeeForm(Container container, EmployeeDto formData)
		{
			_container = container;

			InitializeComponent();

			_employeeService = _container.GetInstance<IEmployeeService>();

			this.formData = formData;

			this.LoadData();
		}

		public void LoadData()
		{
			ClearForm();

			Text_InternalCode.Text = formData.InternalCode;
			Text_Name.Text = formData.Name;
			Text_Sex.Text = formData.Sex;
			DateTime_Birthday.Text = formData.Birthday.ToString();
			Text_Phone.Text = formData.Phone;
		}

		private void ClearForm()
		{
			Text_InternalCode.Clear();
			Text_Name.Clear();
			Text_Sex.Clear();
			DateTime_Birthday.Value = DateTime.Now;
			Text_Phone.Clear();
		}

		private void Button_Save_Click(object sender, EventArgs e)
		{
			formData.InternalCode = Text_InternalCode.Text;
			formData.Name = Text_Name.Text;
			formData.Sex = Text_Sex.Text;
			formData.Birthday = DateTime_Birthday.Value;
			formData.Phone = Text_Phone.Text;

			if (formData.Id != 0)
			{
				_employeeService.Update(formData);
			}
			else
			{
				_employeeService.Create(formData);
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
