using Microsoft.Data.SqlClient;

namespace ASPNET.Models
{
    public class SQLHelper
    {
        public static SqlConnection CreateConnection()  //Connection factory method
        {
            var connString = @"server=200411LTP2831\SQLEXPRESS;database=Testdb;integrated security=true;Encrypt=false;";

            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
