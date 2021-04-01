using DoolittleSE245.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DoolittleSE245.Database
{
    class PersonV2DataBaseIO : DataBaseIO
    {


        public PersonV2DataBaseIO(string server, string port, string db, string user, string password) : base (server, port, db, user, password)
        {

        }

        public DataSet SearchRequest(string command, string parameter, string text)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = command;
            comm.Parameters.AddWithValue($"@{parameter}", "%" + text + "%");
            return ProcessDBRequest(comm, out _);
        }

        public DataSet SearchRequest(SqlCommand comm)
        {
            return ProcessDBRequest(comm, out _);
        }

        public PersonV2 GetPerson(string GUID)
        {
            PersonV2 tmp = new PersonV2();
            SQLCommandBuilder command = new SQLCommandBuilder();
            command.EditCommand("SELECT");
            command.AddParams("FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, HomePhone, Email, MobilePhone, InstagramURL");
            command.EditCommand("FROM", "People");
            command.EditCommand("WHERE", "PersonID = @parameter");

            SqlCommand comm = new SqlCommand();
            comm.CommandText = command.GetSQL();
            comm.Parameters.AddWithValue($"@parameter", GUID);
            DataSet d = ProcessDBRequest(comm, out _);

            try
            {
                tmp.SetNameFirst(d.Tables[0].Rows[0][0].ToString());
                tmp.SetNameMiddle(d.Tables[0].Rows[0][1].ToString());
                tmp.SetNameLast(d.Tables[0].Rows[0][2].ToString());
                tmp.SetStreet1(d.Tables[0].Rows[0][3].ToString());
                tmp.SetStreet2(d.Tables[0].Rows[0][4].ToString());
                tmp.SetCity(d.Tables[0].Rows[0][5].ToString());
                tmp.SetState(d.Tables[0].Rows[0][6].ToString());
                tmp.SetZip(d.Tables[0].Rows[0][7].ToString());
                tmp.SetPhone(d.Tables[0].Rows[0][8].ToString());
                tmp.SetEmail(d.Tables[0].Rows[0][9].ToString());
                tmp.SetMobile(d.Tables[0].Rows[0][10].ToString());
                tmp.SetInstagramURL(d.Tables[0].Rows[0][11].ToString());

            } catch(Exception e)
            {
                
            }

            return tmp;

        }

        public string DropPerson(string GUID, out bool status)
        {
            string strSQL = $"DELETE FROM People WHERE PersonID = @PersonID";
            SqlCommand comm = new SqlCommand
            {
                CommandText = strSQL

           };
            comm.Parameters.AddWithValue("@PersonID",  GUID);
            return ProcessDBCommand(comm, out status);
        }

        public string EditPerson(PersonV2 person, string GUID, out bool status)
        {
            string strSQL = "UPDATE People SET " +
                "FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Street1 = @Street1, Street2 = @Street2, City = @City, " +
                "State = @State, Zip = @Zip, HomePhone = @HomePhone, Email = @Email, MobilePhone = @MobilePhone, InstagramURL = @InstagramURL WHERE PersonID = @PersonID";
            SqlCommand comm = new SqlCommand
            {
                CommandText = strSQL

            };

            comm.Parameters.AddWithValue("@FirstName", person.NameFirst);
            comm.Parameters.AddWithValue("@MiddleName", person.NameMiddle);
            comm.Parameters.AddWithValue("@LastName", person.NameLast);
            comm.Parameters.AddWithValue("@Street1", person.Street1);
            comm.Parameters.AddWithValue("@Street2", person.Street2);
            comm.Parameters.AddWithValue("@City", person.City);
            comm.Parameters.AddWithValue("@State", person.State);
            comm.Parameters.AddWithValue("@Zip", person.Zip);
            comm.Parameters.AddWithValue("@HomePhone", person.Phone);
            comm.Parameters.AddWithValue("@Email", person.Email);
            comm.Parameters.AddWithValue("@MobilePhone", person.Mobile);
            comm.Parameters.AddWithValue("@InstagramURL", person.InstagramURL);
            comm.Parameters.AddWithValue("@PersonID", GUID);

            return ProcessDBCommand(comm, out status);

        }

        public string AddPerson(PersonV2 person, out bool status)
        {
            string strSQL = "INSERT INTO People (" +
                "FirstName, MiddleName, LastName, Street1, Street2, City, " +
                "State, Zip, HomePhone, Email, MobilePhone, InstagramURL, PersonID) " +
                "VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, " +
                "@State, @Zip, @HomePhone, @Email, @MobilePhone, @InstagramURL, NEWID())";
            SqlCommand comm = new SqlCommand
            {
                CommandText = strSQL
                
            };

            comm.Parameters.AddWithValue("@FirstName", person.NameFirst);
            comm.Parameters.AddWithValue("@MiddleName", person.NameMiddle);
            comm.Parameters.AddWithValue("@LastName", person.NameLast);
            comm.Parameters.AddWithValue("@Street1", person.Street1);
            comm.Parameters.AddWithValue("@Street2", person.Street2);
            comm.Parameters.AddWithValue("@City", person.City);
            comm.Parameters.AddWithValue("@State", person.State);
            comm.Parameters.AddWithValue("@Zip", person.Zip);
            comm.Parameters.AddWithValue("@HomePhone", person.Phone);
            comm.Parameters.AddWithValue("@Email", person.Email);
            comm.Parameters.AddWithValue("@MobilePhone", person.Mobile);
            comm.Parameters.AddWithValue("@InstagramURL", person.InstagramURL);

            return ProcessDBCommand(comm, out status);

        }

    }
}
