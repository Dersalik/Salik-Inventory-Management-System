using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Salik_Inventory_Management_System.UI.Configuration;
using Salik_Inventory_Management_System.UI.DataAccess;
using Salik_Inventory_Management_System.UI.Models;
using Salik_Inventory_Management_System.UI.Presenters;
using Salik_Inventory_Management_System.UI.Views;
using Salik_Inventory_Management_System.UI.Views.view_Interfaces;
using Serilog;
using System.Diagnostics;
using System.Globalization;

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
            formats.CurrencySymbol = "$";

            Application.ThreadException += new ThreadExceptionEventHandler(Form1_UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException +=
                 new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            ApplicationConfiguration.Initialize();
            ConfigureServices();
            var db = GetService<InventoryManagementSystemDbContext>();
            //db.Database.Migrate();
            IMainView mainView = GetService<MainView>();
            new MainPresenter(mainView);

            InsertMardAndUser();
            try
            {
                Application.Run((Form)mainView);
            }
            finally
            {
                Log.CloseAndFlush(); // <<#<<#<<#<<#
            }
        }
        public static NumberFormatInfo formats = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
        



       public static ConfigurationForDatabase Config = new ConfigurationForDatabase();
        public static string ConncetionString = Config.configuration.GetConnectionString("DefaultConnection");
        public static  IServiceProvider ServiceProvider { get;  set; }
        public static void ConfigureServices()
        {
            var services = new ServiceCollection();

            //var serilogLogger = new LoggerConfiguration()
            //      .WriteTo.File("loggingFile.txt")
            //      .CreateLogger();
            //dependencies
            services.AddDbContext<InventoryManagementSystemDbContext>(options=>options.UseSqlServer(ConncetionString));
            services.AddSingleton<SalikInventoryManagementDbContextFactory>();
            services.AddSingleton<MainView>();
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(Path.Combine(Directory.GetCurrentDirectory(), "log.txt"), rollingInterval: RollingInterval.Day)
                .CreateLogger();
            ServiceProvider =services.BuildServiceProvider();
        }

        private static void InsertMardAndUser()
        {
            SalikInventoryManagementDbContextFactory factory= GetService<SalikInventoryManagementDbContextFactory>();

            using (InventoryManagementSystemDbContext context = factory.CreateDbContext())
            {
                 bool checkIfMardIsNull = false;
                 bool checkIfUserIsNull = false;
                 checkIfMardIsNull = context.mardCompany.FirstOrDefault()==null;
                 checkIfUserIsNull=context.User.FirstOrDefault()==null;
                if (checkIfMardIsNull)
                {
                    MardCompany addNewMard = new MardCompany()
                    {
                        TotalMoneyOwedByUserToTheCompany = 0
                    };
                    context.mardCompany.Add(addNewMard);
                    context.SaveChanges();
                }

                if (checkIfUserIsNull)
                {
                    User addNewUser = new User()
                    {
                        TotalMoneyOwedByCustomers = 0,
                        TotalMoneyReceivedFromCustomers = 0
                    };
                    context.User.Add(addNewUser);
                    context.SaveChanges();
                }
                
            }

        }
        public static T? GetService<T>() where T:class
        {
            return (T?)ServiceProvider.GetService(typeof(T));
        }
        private static void Form1_UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = ShowThreadExceptionDialog("Windows Forms Error", t.Exception);
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Windows Forms Error",
                        "Fatal Windows Forms Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Abort)
                Application.Exit();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                string errorMsg = "An application error occurred. Please contact the adminstrator " +
                    "with the following information:\n\n";

                // Since we can't prevent the app from terminating, log this to the event log.
                if (!EventLog.SourceExists("ThreadException"))
                {
                    EventLog.CreateEventSource("ThreadException", "Application");
                }

                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog();
                myLog.Source = "ThreadException";
                myLog.WriteEntry(errorMsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show("Fatal Non-UI Error",
                        "Fatal Non-UI Error. Could not write the error to the event log. Reason: "
                        + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errorMsg = "An application error occurred. Please contact the adminstrator " +
                "with the following information:\n\n";
            errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            return MessageBox.Show(errorMsg, title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }

    }
}