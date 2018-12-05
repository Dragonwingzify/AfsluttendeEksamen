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
    public class Handler
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

        /// <summary>
        /// Creates new row in conversion_platform table
        /// </summary>
        /// <param name="listId">The list_id of the row</param>
        /// <param name="input1">The linecode or port</param>
        /// <param name="input2">The pier. Should be NULL when type is 1</param>
        /// <param name="output">The partner tag or terminalcode</param>
        /// <param name="type">Type, either '1' or '2'</param>
        public void SetPartner(string listId, string input1, string input2, string output, int type, bool toThrow)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))
                {
                    sqlCommand = new SqlCommand("dbo.SetPartner", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@input1", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@input1"].Value = input1;
                    sqlCommand.Parameters.Add("@input2", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@input2"].Value = input2;
                    sqlCommand.Parameters.Add("@output", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@output"].Value = output;
                    sqlCommand.Parameters.Add("@Type", SqlDbType.Int);
                    sqlCommand.Parameters["@Type"].Value = type;
                    conn.Open();
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

        /// <summary>
        /// Edits the row in a conversion_platform table.
        /// </summary>
        /// <param name="Id">The designated Id of the row to be edited.</param>
        /// <param name="listId">The list_id of the row</param>
        /// <param name="input1">The linecode or port</param>
        /// <param name="input2">The pier. Should be NULL when type is 1</param>
        /// <param name="output">The partner tag or terminalcode</param>
        /// <param name="type"></param>
        public void UpdatePartner(int Id, string listId, string input1, string input2, string output, int type, bool toThrow)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))
                {
                    sqlCommand = new SqlCommand("dbo.UpdatePartner", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@CurrentId", SqlDbType.Int);
                    sqlCommand.Parameters["@CurrentId"].Value = Id;
                    sqlCommand.Parameters.Add("@ListId", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@ListId"].Value = listId;
                    sqlCommand.Parameters.Add("@input1", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@input1"].Value = input1;
                    sqlCommand.Parameters.Add("@input2", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@input2"].Value = input2;
                    sqlCommand.Parameters.Add("@output", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@output"].Value = output;
                    sqlCommand.Parameters.Add("@Type", SqlDbType.Int);
                    sqlCommand.Parameters["@Type"].Value = type;
                    conn.Open();
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

        /// <summary>
        /// Deletes the row at a designated Id.
        /// </summary>
        /// <param name="Id">The designated Id which matches the row you want to delete.</param>
        public void DeletePartner(int Id, bool toThrow)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))
                {
                    sqlCommand = new SqlCommand("dbo.DeletePartner", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@CurrentId");
                    sqlCommand.Parameters["@CurrentId"].Value = Id;
                    conn.Open();
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
                if (toThrow == true)
                {
                    throw ex;
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
                if (toThrow == true)
                {
                    throw ex;
                }
            }
            Console.WriteLine("Output is: {0}", output);
            return output;
        }

        public void SetRow(string listID, string port, string pier, string output, string type)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))

                {
                    sqlCommand = new SqlCommand("dbo.SetPartner", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@ListId", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@ListId"].Value = listID;
                    sqlCommand.Parameters.Add(new SqlParameter("@Port", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Port"].Value = port;
                    sqlCommand.Parameters.Add(new SqlParameter("@Pier", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Pier"].Value = pier;
                    sqlCommand.Parameters.Add(new SqlParameter("@Output", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Output"].Value = output;
                    sqlCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    sqlCommand.Parameters["@Type"].Value = type;
                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Row has been added");
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Row Has Not Been Added");
            }
            
        }

        public void UpdateRow(string currentId, string listID, string port, string pier, string output, string type)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))

                {
                    sqlCommand = new SqlCommand("dbo.UpdatePartner", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@CurrentId", SqlDbType.Int));
                    sqlCommand.Parameters["@CurrentId"].Value = currentId;
                    sqlCommand.Parameters.Add(new SqlParameter("@ListId", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@ListId"].Value = listID;
                    sqlCommand.Parameters.Add(new SqlParameter("@Port", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Port"].Value = port;
                    sqlCommand.Parameters.Add(new SqlParameter("@Pier", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Pier"].Value = pier;
                    sqlCommand.Parameters.Add(new SqlParameter("@Output", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Output"].Value = output;
                    sqlCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    sqlCommand.Parameters["@Type"].Value = type;
                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Row has been Updated");
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Row Has Not Been Updated");
            }

        }

        public void DeleteRow(string currentId, string listID, string port, string pier, string output, string type)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))

                {
                    sqlCommand = new SqlCommand("dbo.DeletePartner", conn);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@CurrentId", SqlDbType.Int));
                    sqlCommand.Parameters["@CurrentId"].Value = currentId;
                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Row has been Deleted");
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Row Has Not Been Deleted");
            }

        }
    }
}
