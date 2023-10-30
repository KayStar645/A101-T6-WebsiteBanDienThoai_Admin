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
                InternalCode = "NVQT1",
                Name = "Ngô Văn Sơn",
            };

            var reuslt = await _employeeService.Create(abc);

            var login = await _authService.Login(new UserDto { Password = "NVQT1", UserName = "NVQT1" });

            AuthRespone x = ServiceCommon.AuthRespone;

            int a = 1;


        }
    }
}
