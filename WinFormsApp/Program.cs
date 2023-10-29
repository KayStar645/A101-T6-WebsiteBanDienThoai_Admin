using AutoMapper;
using Database.Interfaces;
using Database.Repositories;
using Services.Interfaces;
using Services.Profiles;
using Services.Services;
using SimpleInjector;
using WinFormsApp.View.Screen;

namespace WinFormsApp
{
    internal static class Program
    {
        public static Admin? admin = null;
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

            // Đăng ký Repository
            container.Register<IDistributorRepository, DistributorRepository>();

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
            container.Register<IDistributorService, DistributorService>();

            admin = new Admin();

            Application.Run(admin);
        }
    }

}