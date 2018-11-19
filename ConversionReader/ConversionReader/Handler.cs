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
        
        SqlCommand sqlCommand;
       string connectionstring = @"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12";
       public string sql;
        string cmdSqlGet;

        public Handler(string sqlServer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12"))  //initialized
            {
                try
                {

                    connectionstring = sqlServer;
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.CommandText = "SELECT * FROM convert_platform";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    Console.WriteLine("Database: " + sqlConnection.Database);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Couldn't connect to any database! error: " + e);
                }
            }

        }

        public string GetLineCode(string listID, string lineCode, string type, bool toThrow)
        {
            string output = "";
            using (var conn = new SqlConnection(connectionstring))
            using (sqlCommand = new SqlCommand("GetLinecode", conn) { CommandType = System.Data.CommandType.StoredProcedure })
            {
                sqlCommand.Parameters.Add(new SqlParameter("@listId", listID));
                sqlCommand.Parameters.Add(new SqlParameter("@Terminal", lineCode));
                conn.Open();
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        output = (string)reader["Output"];
                    }
                }
            }
            return output;
        }
        public string GetTermCode(string listID, string port, string pier, string type, bool toThrow)
        {
            string output = "";
            using (var conn = new SqlConnection(connectionstring))
            using (sqlCommand = new SqlCommand("GetTerminal", conn) { CommandType = System.Data.CommandType.StoredProcedure })
            {
                sqlCommand.Parameters.Add(new SqlParameter("@list_id", listID));
                sqlCommand.Parameters.Add(new SqlParameter("@Port", port));
                sqlCommand.Parameters.Add(new SqlParameter("@Pier", pier));
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        output = (string)reader["Output"];
                    }
                }
                
            }
            return output;
        }
    }
}
