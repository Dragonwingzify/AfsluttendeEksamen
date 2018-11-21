using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))  //initialized
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

        public string GetLineCode(string listID, string terminal, bool toThrow)
        {
            string output = "";
            try
            {
                using (var conn = new SqlConnection(connectionstring))
                {
                    sqlCommand = new SqlCommand("dbo.GetLinecode", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@ListId", SqlDbType.VarChar);
                    sqlCommand.Parameters["@ListId"].Value = listID;
                    sqlCommand.Parameters.Add("@Terminal", SqlDbType.VarChar);
                    sqlCommand.Parameters["@Terminal"].Value = terminal;
                    conn.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output = reader.GetString(reader.GetOrdinal("Output"));
                        }
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                if(toThrow == true)
                {
                    throw ex;
                }

            }
            if(output == "")
            {
                try
                {
                    using (var conn = new SqlConnection(connectionstring))
                    {
                        sqlCommand = new SqlCommand("dbo.GetLinecode", conn);
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add("@ListId", SqlDbType.VarChar);
                        sqlCommand.Parameters["@ListId"].Value = "DEFAULT";
                        sqlCommand.Parameters.Add("@Terminal", SqlDbType.VarChar);
                        sqlCommand.Parameters["@Terminal"].Value = terminal;
                        conn.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                output = reader.GetString(reader.GetOrdinal("Output"));
                            }
                        }
                        conn.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    if (toThrow == true)
                    {
                        throw ex;
                    }

                }
            }
            Console.WriteLine("Output is: {0}", output);
            return output;
        }
        public string GetTermCode(string listID, string port, string pier, bool toThrow)
        {
            string output = "";
            try
            {
                using (var conn = new SqlConnection(connectionstring))
                using (sqlCommand = new SqlCommand("dbo.GetTerminal", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@listId", listID));
                    sqlCommand.Parameters.Add(new SqlParameter("@Port", port));
                    sqlCommand.Parameters.Add(new SqlParameter("@Pier", pier));
                    conn.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output = (string)reader["output"];
                        }
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                if(toThrow == true)
                {
                    throw ex;
                }
            }
            if(output == "")
            {
                try
                {
                    using (var conn = new SqlConnection(connectionstring))
                    using (sqlCommand = new SqlCommand("dbo.GetTerminal", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@listId", "DEFAULT"));
                        sqlCommand.Parameters.Add(new SqlParameter("@Port", port));
                        sqlCommand.Parameters.Add(new SqlParameter("@Pier", pier));
                        conn.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                output = (string)reader["output"];
                            }
                        }
                        conn.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    if (toThrow == true)
                    {
                        throw ex;
                    }
                }
            }
            return output;
        }
    }
}
