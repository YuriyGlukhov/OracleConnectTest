using OracleConnectTest.Service;

namespace OracleConnectTest
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
            string connectionString = "User Id=adm;Password=a2207dm;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=PROCARS)))";
            ManageClientsService service = new ManageClientsService(connectionString);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(service));
        }
    }
}