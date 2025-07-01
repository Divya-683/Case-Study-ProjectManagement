using System.Data.SqlClient;

namespace ProjectManagement.Utility
{
    public static class DBConnection
    {
        private static readonly string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ProjectManagements;Trusted_Connection=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
