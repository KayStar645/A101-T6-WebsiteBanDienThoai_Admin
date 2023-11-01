using Controls.UI;
using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using SimpleInjector;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Employee
{
	public partial class EmployeeControl : UserControl
	{
		private readonly IEmployeeService _employeeService;
		public static Guna2Button _refreshButton = new Guna2Button();
		(List<EmployeeDto> list, int totalCount, int pageNumber) _result;
		int _currPage = 1;

		public EmployeeControl()
		{

			InitializeComponent();

			_employeeService = Program.container.GetInstance<IEmployeeService>();
			_refreshButton = Button_Refresh;
			InitializeAsync();
		}

		public EmployeeControl(List<EmployeeDto> employees)
		{
			InitializeComponent();

			_employeeService = Program.container.GetInstance<IEmployeeService>();


			_refreshButton = Button_Refresh;

			LoadData(employees);
		}

		private async void InitializeAsync()
		{
			_result = await _employeeService.GetList("Name", 1, 15, "");

			DataGridView_Listing.DataSource = _result.list;

			_refreshButton = Button_Refresh;

			Paginator();
		}

		private void Paginator()
		{
			FlowLayoutPanel_Paginator.Controls.Clear();

			for (int i = 1; i <= _result.pageNumber; i++)
			{
				PaginatorButton button = new(i.ToString(), Button_Paginator_Click);

				FlowLayoutPanel_Paginator.Controls.Add(button);
			}

			if (_result.pageNumber > 0)
			{
				FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.RoyalBlue;
				FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.White;
			}
		}

		private async void Button_Paginator_Click(object sender, EventArgs e)
		{
			Guna2Button button = (Guna2Button)sender;

			FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.White;
			FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.Black;

			_currPage = int.Parse(button.Text);

			FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].BackColor = Color.RoyalBlue;
			FlowLayoutPanel_Paginator.Controls[_currPage - 1].Controls[0].ForeColor = Color.White;

			_result = await _employeeService.GetList("Name", _currPage, 15, "");


			LoadData(_result.list);
		}

		public void LoadData(List<EmployeeDto> employees)
		{
			DataGridView_Listing.DataSource = employees;
		}

		private void Button_Create_Click(object sender, EventArgs e)
		{
			Util.LoadForm(new EmployeeForm(), true);
		}

		private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;
			EmployeeDto formData = new()
			{
				Id = int.Parse(selected["Id"].FormattedValue.ToString()),
				InternalCode = selected["InternalCode"].FormattedValue.ToString(),
				Name = selected["_Name"].FormattedValue.ToString(),
				Sex = selected["Sex"].FormattedValue.ToString(),
				Birthday = DateTime.Parse(selected["Birthday"].FormattedValue.ToString()),
				Phone = selected["Phone"].FormattedValue.ToString(),
			};

			if (e.ColumnIndex == 0)
			{
				Util.LoadForm(new EmployeeForm(formData), true);
			}
			else if (e.ColumnIndex == 1)
			{
				DialogResult dialogResult = Dialog_Confirm.Show();

				if (dialogResult != DialogResult.Yes)
				{
					return;
				}

				_employeeService.Delete(formData.Id);
				Button_Refresh.PerformClick();
			}
		}

		private async void Button_Refresh_Click(object sender, EventArgs e)
		{
			_result = await _employeeService.GetList("Name", 1, 15, "");

			LoadData(_result.list);
		}

		private void Text_Search_TextChanged(object sender, EventArgs e)
		{
			Timer_Debounce.Stop();
			Timer_Debounce.Start();
		}

		private async void Timer_Debounce_Tick(object sender, EventArgs e)
		{
			_currPage = 1;

			Paginator();

			_result = await _employeeService.GetList("Name", _currPage, 15, Text_Search.Text);

			LoadData(_result.list);
		}
	}
}
