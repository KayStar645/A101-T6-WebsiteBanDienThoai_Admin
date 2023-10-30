﻿using AutoMapper;
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
            container.Register<ICustomerRepository, CustomerRepository>();
            container.Register<IEmployeeRepository, EmployeeRepository>();
            container.Register<ICategoryRepository, CategoryRepository>();
            container.Register<ICapacityRepository, CapacityRepository>();
            container.Register<IColorRepository, ColorRepository>();

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
            container.Register<ICustomerService, CustomerService>();
            container.Register<IEmployeeService, EmployeeService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ICapacityService, CapacityService>();
            container.Register<IColorService, ColorService>();

            admin = new Admin();

            Application.Run(admin);
        }
    }

}