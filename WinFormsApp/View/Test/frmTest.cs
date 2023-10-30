using Domain.DTOs;
using Services.Common;
using Services.Interfaces;
using SimpleInjector;

namespace WinFormsApp.View.Test
{
    public partial class frmTest : Form
    {

        private readonly Container _container;
        private readonly IAuthService _authService;
        private readonly IEmployeeService _employeeService;
        public frmTest(Container container)
        {

            _container = container;

            InitializeComponent();

            _authService = _container.GetInstance<IAuthService>();
            _employeeService = _container.GetInstance<IEmployeeService>();

            Test();
        }

        private async Task Test()
        {
            EmployeeDto abc = new EmployeeDto()
            {
                InternalCode = "123",
                Name = "Name",
            };

            var reuslt = await _employeeService.Create(abc);

            var login = await _authService.Login(new UserDto { Password = "123", UserName = "123"});

            AuthRespone x = ServiceCommon.AuthRespone;

            int a = 1;


        }
    }
}
