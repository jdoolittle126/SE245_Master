using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoolittleSE245.Database
{
    abstract class DataBaseWriter
    {
        private SqlConnection databaseConnection;


        public DataBaseWriter(string server, string port, string db, string user, string password)
        {
            databaseConnection = new SqlConnection($"Server={server},{port};Database={db};User Id={user};Password={password};");
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
