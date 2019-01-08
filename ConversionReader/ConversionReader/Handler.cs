using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

enum SQL
{
    CREATE, UPDATE, PUT, DROP, DELETE
};
namespace ConversionReader
{
    public class Handler
    {
        //Fields: SQL Data object which references the ConversionReader table

        public SqlCommand SqlCommand { get; set; }
        private string connectionstring = @"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12";
        public string ConnectionString { get { return connectionstring; } }
        public string Sql;
        string cmdSqlGet;

        public Handler(string sqlServer)
        {
            //using (SqlConnection sqlConnection = new SqlConnection(connectionstring))  //initialized
            //{
            //    try
            //    {

            //        connectionstring = sqlServer;
            //        SqlCommand = new SqlCommand(Sql, sqlConnection);
            //        sqlConnection.Open();
            //        SqlCommand.CommandText = "SELECT * FROM convert_platform";
            //        SqlCommand.ExecuteNonQuery();
            //        SqlCommand.Dispose();
            //        Console.WriteLine("Database: " + sqlConnection.Database);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Couldn't connect to any database! error: " + e);
            //    }
            //}

        }

        public Row GetFromLineCode(string listID, string lineCode, bool toThrow)
        {
            Row row = null;
            try
            {
                using (var conn = new SqlConnection(connectionstring))
                {
                    SqlCommand = new SqlCommand("dbo.GetFromLineCode", conn);
                    SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommand.Parameters.Add("@ListId", SqlDbType.NVarChar);
                    SqlCommand.Parameters["@ListId"].Value = listID;
                    SqlCommand.Parameters.Add("@Linecode", SqlDbType.NVarChar);
                    SqlCommand.Parameters["@Linecode"].Value = lineCode;
                    conn.Open();
                    using (SqlDataReader reader = SqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            row = new Row(reader.GetInt32(reader.GetOrdinal("id")), reader.GetString(reader.GetOrdinal("list_id")), reader.GetString(reader.GetOrdinal("input1")), 
                                "", reader.GetString(reader.GetOrdinal("output")));
                            
                        }
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                row = new Row(0, "", "", "", "");
                if (toThrow == true)
                {
                    MessageBox.Show(ex.ToString());
                    //throw ex;
                }

            }
            if (row == null)
            {
                row = new Row(0, "", "", "", "");
            }
            Console.WriteLine("Output is: {0}", row.Output);
            return row;
        }
        public Row GetFromPortAndPier(string listID, string port, string pier, bool toThrow)
        {
            Row row = null;
            try
            {
                using (var conn = new SqlConnection(connectionstring))

                {
                    SqlCommand = new SqlCommand("dbo.GetFromPortAndPier", conn);
                    SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommand.Parameters.Add(new SqlParameter("@listId", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@ListId"].Value = listID;
                    SqlCommand.Parameters.Add(new SqlParameter("@Port", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@Port"].Value = port;
                    SqlCommand.Parameters.Add(new SqlParameter("@Pier", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@Pier"].Value = pier;
                    conn.Open();
                    using (SqlDataReader reader = SqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            row = new Row(reader.GetInt32(reader.GetOrdinal("id")), reader.GetString(reader.GetOrdinal("list_id")), reader.GetString(reader.GetOrdinal("input1")),
                                reader.GetString(reader.GetOrdinal("input2")), reader.GetString(reader.GetOrdinal("output")));
                        }
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                row = new Row(0, "", "", "", "");
                if (toThrow == true)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (row == null)
            {
                row = new Row(0, "", "", "", "");
            }
            Console.WriteLine("Output is: {0}", row.Output);
            return row;
        }

        public void SetRow(string listID, string input1, string input2, string output, int type, bool toThrow)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))

                {
                    SqlCommand = new SqlCommand("dbo.SetPartner", conn);
                    SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommand.Parameters.Add(new SqlParameter("@ListId", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@ListId"].Value = listID;
                    SqlCommand.Parameters.Add(new SqlParameter("@Input1", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@Input1"].Value = input1;
                    if (input2 == "NULL")
                    {
                        SqlCommand.Parameters.Add(new SqlParameter("@Input2", SqlDbType.NVarChar));
                        SqlCommand.Parameters["@Input2"].Value = DBNull.Value;
                    }
                    else
                    {
                        SqlCommand.Parameters.Add(new SqlParameter("@Input2", SqlDbType.NVarChar));
                        SqlCommand.Parameters["@Input2"].Value = input2;
                    }
                    SqlCommand.Parameters.Add(new SqlParameter("@Output", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@Output"].Value = output;
                    SqlCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    SqlCommand.Parameters["@Type"].Value = type;
                    conn.Open();
                    SqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Row has been added");
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (toThrow == true)
                {
                    MessageBox.Show(ex.ToString());
                }
                Console.WriteLine("Row Has Not Been Added");
            }

        }

        public void UpdateRow(string currentId, string listID, string input1, string input2, string output, int type, bool toThrow)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))

                {
                    SqlCommand = new SqlCommand("dbo.UpdatePartner", conn);
                    SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommand.Parameters.Add(new SqlParameter("@CurrentId", SqlDbType.Int));
                    SqlCommand.Parameters["@CurrentId"].Value = currentId;
                    SqlCommand.Parameters.Add(new SqlParameter("@ListId", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@ListId"].Value = listID;
                    SqlCommand.Parameters.Add(new SqlParameter("@Input1", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@Input1"].Value = input1;
                    if (input2 == "NULL")
                    {
                        SqlCommand.Parameters.Add(new SqlParameter("@Input2", SqlDbType.NVarChar));
                        SqlCommand.Parameters["@Input2"].Value = DBNull.Value;
                    }
                    else
                    {
                        SqlCommand.Parameters.Add(new SqlParameter("@Input2", SqlDbType.NVarChar));
                        SqlCommand.Parameters["@Input2"].Value = input2;
                    }
                    SqlCommand.Parameters.Add(new SqlParameter("@Output", SqlDbType.NVarChar));
                    SqlCommand.Parameters["@Output"].Value = output;
                    SqlCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int));
                    SqlCommand.Parameters["@Type"].Value = type;
                    conn.Open();
                    SqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Row has been Updated");
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (toThrow == true)
                {
                    MessageBox.Show(ex.ToString());
                }
                Console.WriteLine("Row Has Not Been Updated");
            }

        }

        public void DeleteRow(string currentId, bool toThrow)
        {
            try
            {
                using (var conn = new SqlConnection(connectionstring))

                {
                    SqlCommand = new SqlCommand("dbo.DeletePartner", conn);
                    SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommand.Parameters.Add(new SqlParameter("@CurrentId", SqlDbType.Int));
                    SqlCommand.Parameters["@CurrentId"].Value = currentId;
                    conn.Open();
                    SqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Row has been Deleted");
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (toThrow == true)
                {
                    MessageBox.Show(ex.ToString());
                    throw ex;
                }
                Console.WriteLine("Row Has Not Been Deleted");
            }

        }
    }
}
