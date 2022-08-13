using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Salik_Inventory_Management_System.UI.Configuration;
using Salik_Inventory_Management_System.UI.DataAccess;
using Salik_Inventory_Management_System.UI.DataAccess.Repository;
using Salik_Inventory_Management_System.UI.Models;

namespace Salik_Inventory_Management_System.UI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConfigureServices();
            var db = GetService<InventoryManagementSystemDbContext>();
            db.Database.EnsureCreatedAsync().Wait();
           
            Application.Run(new Form1());
        }
       public static ConfigurationForDatabase Config = new ConfigurationForDatabase();
        public static string ConncetionString = Config.configuration.GetConnectionString("DefaultConnection");
        public static  IServiceProvider ServiceProvider { get;  set; }
        public static void ConfigureServices()
        {
            var services = new ServiceCollection();
            
            //dependencies
            services.AddDbContext<InventoryManagementSystemDbContext>(options=>options.UseSqlServer(ConncetionString));
            services.AddSingleton<SalikInventoryManagementDbContextFactory>();
            ServiceProvider=services.BuildServiceProvider();
        }

        public static T? GetService<T>() where T:class
        {
            return (T?)ServiceProvider.GetService(typeof(T));
        }
    }
}