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
        private readonly ISpecificationsService _specificationsService;
        private readonly IDetailSpecificationsService _detailSpecificationsService;



        public frmTest(Container container)
        {

            _container = container;

            InitializeComponent();

            _authService = _container.GetInstance<IAuthService>();
            _employeeService = _container.GetInstance<IEmployeeService>();
            _productService = _container.GetInstance<IProductService>();
            _specificationsService = _container.GetInstance<ISpecificationsService>();
            _detailSpecificationsService = _container.GetInstance<IDetailSpecificationsService>();

            //Test();

            //Test2();

            Test3();
        }

        async Task Test3()
        {
            var r1 = await _specificationsService.GetList("Name", 1, 15, "");

            var r2 = await _detailSpecificationsService.GetListBySpecificationsIdAsync(1);
            var r3 = await _detailSpecificationsService.GetListBySpecificationsIdAsync(2);

            int a = 1;
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
