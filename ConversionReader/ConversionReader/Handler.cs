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

        public string GetFromLineCode(string listID, string lineCode, bool toThrow)
        {
            string output = "";
            try
            {
                using (var conn = new SqlConnection(connectionstring))
                {
                    sqlCommand = new SqlCommand("dbo.GetFromLineCode", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@ListId", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@ListId"].Value = listID;
                    sqlCommand.Parameters.Add("@Linecode", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@Linecode"].Value = lineCode;
                    conn.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output = reader.GetString(reader.GetOrdinal("output"));
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
                        sqlCommand = new SqlCommand("dbo.GetFromLineCode", conn);
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add("@ListId", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@ListId"].Value = "DEFAULT";
                        sqlCommand.Parameters.Add("@Linecode", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@Linecode"].Value = lineCode;
                        conn.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                output = reader.GetString(reader.GetOrdinal("output"));
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
        public string GetFromPortAndPier(string listID, string port, string pier, bool toThrow)
        {
            string output = "";
            try
            {
                using (var conn = new SqlConnection(connectionstring))
                
                {
                    sqlCommand = new SqlCommand("dbo.GetFromPortAndPier", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@listId", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@ListId"].Value = listID;
                    sqlCommand.Parameters.Add(new SqlParameter("@Port", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Port"].Value = port;
                    sqlCommand.Parameters.Add(new SqlParameter("@Pier", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Pier"].Value = pier;
                    conn.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output = reader.GetString(reader.GetOrdinal("output"));
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
                    using (sqlCommand = new SqlCommand("dbo.GetFromPortAndPier", conn) { CommandType = System.Data.CommandType.StoredProcedure })
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
            Console.WriteLine("Output is: {0}", output);
            return output;
        }
    }
}
