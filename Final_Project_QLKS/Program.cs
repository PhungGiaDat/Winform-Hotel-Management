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
            string userRole = "Receptionist"; // Replace with the appropriate role
            Application.Run(new MainDashboardForm(userRole));
        }
    }
}
