using AutoMapper;
using Database.Interfaces;
using Database.Repositories;
using Domain.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Services.Interfaces;
using Services.Profiles;
using Services.Services;
using SimpleInjector;
using WinFormsApp.View.Auth;
using WinFormsApp.View.Screen;
using WinFormsApp.View.Test;

namespace WinFormsApp
{
    internal static class Program
    {
        public static Admin? admin = null;
        public static Login? login = null;
        public static Container container;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Khởi tạo container
            container = new Container();

            // Đăng ký dịch vụ phụ thuộc vào container

            // Đăng ký IConfiguration
            container.Register<IConfiguration>(() =>
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                return builder.Build();
            });

            // Đăng ký Repository
            container.Register<IDistributorRepository, DistributorRepository>();
            container.Register<ICustomerRepository, CustomerRepository>();
            container.Register<IEmployeeRepository, EmployeeRepository>();
            container.Register<IUserRepository, UserRepository>();
            container.Register<ICategoryRepository, CategoryRepository>();
            container.Register<ICapacityRepository, CapacityRepository>();
            container.Register<IColorRepository, ColorRepository>();
            container.Register<IProductParametersRepository, ProductParametersRepository>();
            container.Register<IProductRepository, ProductRepository>();
            container.Register<ISpecificationsRepository, SpecificationsRepository>();
            container.Register<IDetailSpecificationsRepository, DetailSpecificationsRepository>();
            container.Register<IImportBillRepository, ImportBillRepository>();
            container.Register<IDetailImportRepository, DetailImportRepository>();
            container.Register<IPromotionRepository, PromotionRepository>();
            container.Register<IPromotionProductRepository, PromotionProductRepository>();
            container.Register<IOrderRepository, OrderRepository>();
            container.Register<IDetailOrderRepository, DetailOrderRepository>();
            container.Register<IPermissionRepository, PermissionRepository>();
            container.Register<IRoleRepository, RoleRepository>();

            // Đăng ký mapper
            container.Register<IMapper>(() =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<MappingProfile>();
                });
                return config.CreateMapper();
            });

            // Đăng ký dịch vụ Service
            container.Register<IPasswordHasher<UserDto>, PasswordHasher<UserDto>>();
            container.Register<IOptions<PasswordHasherOptions>>(() =>
            {
                var options = new PasswordHasherOptions
                {
                    CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2,
                };

                return Options.Create(options);
            });

            container.Register<IDistributorService, DistributorService>();
            container.Register<ICustomerService, CustomerService>();
            container.Register<IEmployeeService, EmployeeService>();
            container.Register<IAuthService, AuthService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ICapacityService, CapacityService>();
            container.Register<IColorService, ColorService>();
            container.Register<IProductParametersService, ProductParametersService>();
            container.Register<IProductService, ProductService>();
            container.Register<ISpecificationsService, SpecificationsService>();
            container.Register<IDetailSpecificationsService, DetailSpecificationsService>();
            container.Register<IImportBillService, ImportBillService>();
            container.Register<IPromotionService, PromotionService>();
            container.Register<IPromotionProductService, PromotionProductService>();
            container.Register<IOrderService, OrderService>();
            container.Register<IPermissionService, PermissionService>();
            container.Register<IRoleService, RoleService>();

            admin = new Admin();
            login = new Login();

            //Application.Run(admin);
            //Application.Run(login);
            Application.Run(new frmTest(container));
        }
    }

}