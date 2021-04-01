using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoolittleSE245.Database
{
    abstract class DataBaseIO
    {
        private SqlConnection databaseConnection;


        public DataBaseIO(string server, string port, string db, string user, string password)
        {
            databaseConnection = new SqlConnection($"Server={server},{port};Database={db};User Id={user};Password={password};");
        }



        protected DataSet ProcessDBRequest(SqlCommand c, out bool status)
        {

            DataSet data = new DataSet();
            string feedback; //Not implemented
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                c.Connection = databaseConnection;
                adapter.SelectCommand = c;   
                databaseConnection.Open(); 
                feedback = $"SUCCESS: {adapter.Fill(data, "Search Results")} rows added/updated!";
                databaseConnection.Close();
                status = true;


            }
            catch (Exception err)
            {
                databaseConnection.Close();
                feedback = "ERROR: " + err.Message;
                status = false;
            }
            return data;
        }

        protected string ProcessDBCommand(SqlCommand c, out bool status)
        {
            string feedback;
            try
            {
                c.Connection = databaseConnection;
                databaseConnection.Open();
                feedback = $"SUCCESS: {c.ExecuteNonQuery()} rows effected.";
                databaseConnection.Close();
                status = true;
            }
            catch (Exception err) 
            {
                feedback = "ERROR: " + err.Message;
                status = false;
            }
            return feedback;
        }


    }
}
