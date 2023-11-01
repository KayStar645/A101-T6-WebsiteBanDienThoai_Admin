using Domain.DTOs;
using Domain.ModelViews;
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
        private readonly IProductService _productService;


        public frmTest(Container container)
        {

            _container = container;

            InitializeComponent();

            _authService = _container.GetInstance<IAuthService>();
            _employeeService = _container.GetInstance<IEmployeeService>();
            _productService = _container.GetInstance<IProductService>();

            //Test();

            Test2();
        }

        private async Task Test2()
        {
            var result = await _productService.GetDetail(2);

            int a = 1;

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

            AuthVM x = ServiceCommon.AuthRespone;

            int a = 1;


        }
    }
}
