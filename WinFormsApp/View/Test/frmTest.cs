using Domain.DTOs;
using Domain.ModelViews;
using Services.Common;
using Services.Interfaces;
using Services.Interfaces.GoogleDrive;
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
        private readonly IImportBillService _importBillService;
        private readonly IOrderService _orderService;
        private readonly IPromotionService _promotionService;
        private readonly IPermissionService _permissionService;
        private readonly IRoleService _roleService;
        private readonly IGoogleDriveService _googleDriveService;



        public frmTest(Container container)
        {

            _container = container;

            InitializeComponent();

            _authService = _container.GetInstance<IAuthService>();
            _employeeService = _container.GetInstance<IEmployeeService>();
            _productService = _container.GetInstance<IProductService>();
            _specificationsService = _container.GetInstance<ISpecificationsService>();
            _detailSpecificationsService = _container.GetInstance<IDetailSpecificationsService>();
            _importBillService = _container.GetInstance<IImportBillService>();
            _orderService = _container.GetInstance<IOrderService>();
            _promotionService = _container.GetInstance<IPromotionService>();

            _permissionService = _container.GetInstance<IPermissionService>();
            _roleService = _container.GetInstance<IRoleService>();
            _googleDriveService = _container.GetInstance<IGoogleDriveService>();

            //Test();

            //Test2();

            //Test3();

            //Test4();

            //Test5();

            //Test6();

            TestIdentities();

            //TestUpload();
            int a = 1;
        }

        private async Task TestUpload()
        {
            var x = await _googleDriveService.UploadFilesToGoogleDrive(new UploadVM
            {
                FilePath = "https://image.nhandan.vn/Uploaded/2023/unqxwpejw/2023_09_24/anh-dep-giao-thong-1626.jpg",
                FileName = "test/1/abc"
            });
        }    

        private async Task TestIdentities()
        {
            var x = _permissionService.GetRequiredPermissions();

            //var y = await _permissionService.Create(x);

            var role = await _roleService.Update(new RoleVM
            {
                Id = 4,
                Name = "Quyền của Thuận",
                PermissionsName = x
            });

            //var roles = await _roleService.GetList();

            var c = await _roleService.AssignRoles(new AssignRoleVM
            {
                UserId = 1,
                RoleId = 4
            });



            int a = 1;
        }

        private async Task Test6()
        {
            await _promotionService.ApplyForProduct(1, new List<int> { 1, 2 });

            int a = 1;
        }

        private async Task Test5()
        {
            var result = await _orderService.GetList();

            var result2 = await _orderService.GetDetail(1);

            int a = 1;
        }

        private async Task Test4()
        {
            //var result = await _importBillService.GetDetail(2);

            await _importBillService.Create(new ImportBillDto
            {
                InternalCode = "999",

            });

            int a = 1;
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
