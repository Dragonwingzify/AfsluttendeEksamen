using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
enum SQL
{
    CREATE, UPDATE, PUT, DROP, DELETE
};
namespace ConversionReader
{
    class Handler
    {
        //Fields: SQL Data object which references the ConversionReader table
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string connectionstring;
        string sql;
    
        string cmdSqlGet;

        public Handler(string sqlServer)
        {
            try
            {
                connectionstring = sqlServer;
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                Console.WriteLine("Database: " + sqlConnection.Database);
            }
            catch(Exception e)
            {
                Console.WriteLine("Couldn't connect to any database! error: " + e);
            }
        }

        public string GetLineCode()
        {
            sqlCommand.ExecuteReader();

            return "placeholder";
        }
        public string GetTermCode()
        {
            return "placeholer";
        }
    }
}
