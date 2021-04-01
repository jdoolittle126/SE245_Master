using DoolittleSE245.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoolittleSE245.Database
{
    class PersonV2DataBaseWriter : DataBaseWriter
    {


        public PersonV2DataBaseWriter(string server, string port, string db, string user, string password) : base (server, port, db, user, password)
        {

        }

        public string AddPerson(PersonV2 person, out bool status)
        {
            string strSQL = "INSERT INTO People (" +
                "FirstName, MiddleName, LastName, Street1, Street2, City, " +
                "State, Zip, HomePhone, Email, MobilePhone, InstagramURL) " +
                "VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, " +
                "@State, @Zip, @HomePhone, @Email, @MobilePhone, @InstagramURL)";
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
