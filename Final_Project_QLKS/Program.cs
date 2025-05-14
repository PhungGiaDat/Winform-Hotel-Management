using Final_Project_QLKS.Core.Seeding;
using Final_Project_QLKS.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_QLKS
{
    internal static class Program
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

            // Pass the required 'role' argument to the MainDashboardForm constructor
            var context = new QlkhachsanContext();

            // Show the actual database name being used
            var dbName = context.Database.GetDbConnection().Database;
            MessageBox.Show($"Seeding database: {dbName}");

            try
            {
                DatabaseSeeder.SeedOnce(context);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Seeding Error");
            }


            Application.Run(new LoginForm());
        }
    }
}
