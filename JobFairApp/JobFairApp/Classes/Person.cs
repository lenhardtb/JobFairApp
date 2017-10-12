using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace JobFairApp.Classes
{
    public class Person : ISQLObject<Person>
    {
        public int ID = MySQLUtils.NullID; 
        public String First;//15 chars
        public char MI;
        public String Last;//30 chars
        public int Title;
        public String Address1;//25 chars
        public String Address2;//25 chars
        public String City;//20 chars
        public String State;//2 chars
        public String Zip;//10 chars
        public String Email;//35 chars
        public String Phone;//13 chars

        public Person FromID(int ID)
        {
            String query = "SELECT * FROM People WHERE ID = '" + ID + "'";

            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            connection.Close();

            return FromDataReader(reader);
        }

        public Person FromDataReader(SqlDataReader reader)
        {
            if(!reader.HasRows)
            {
                ID = MySQLUtils.NullID;
                First = null;
                MI = '\0';
                Last = null;
                Address1 = null;
                Address2 = null;
                City = null;
                State = null;
                Zip = null;
                Email = null;
                Phone = null;

                return this;
            }

            ID = reader.GetInt32(reader.GetOrdinal("ID"));
            First = reader.GetString(reader.GetOrdinal("First"));
            MI = reader.GetChar(reader.GetOrdinal("MI"));
            Last = reader.GetString(reader.GetOrdinal("Last"));
            Address1 = reader.GetString(reader.GetOrdinal("Address1"));
            Address2 = reader.GetString(reader.GetOrdinal("Address2"));
            City = reader.GetString(reader.GetOrdinal("City"));
            State = reader.GetString(reader.GetOrdinal("State"));
            Zip = reader.GetString(reader.GetOrdinal("Zip"));
            Email = reader.GetString(reader.GetOrdinal("Email"));
            Phone = reader.GetString(reader.GetOrdinal("Phone"));

            reader.Read();//advance reader because it may have other records

            return this;
        }

        public Person FromDataRow(DataRow row)
        {
            ID = (int)row["ID"];
            First = (string)row["First"];
            MI = (char)row["MI"];
            Last = (string)row["Last"];
            Address1 = (string)row["Address1"];
            Address2 = (string)row["Address2"];
            City = (string)row["City"];
            State = (string)row["State"];
            Zip = (string)row["Zip"];
            Email = (string)row["Email"];
            Phone = (string)row["Phone"];

            return this;
        }

        public int Insert()
        {
            String statement;
            statement = "INSERT INTO People " +
                    "(First, MI, Last, Title, " +
                    "Address1, Address2, City, State, Zip, " +
                    "Email, Phone) VALUES" +
                     "(" +
                     "'" + First    + "'," +
                     "'" + MI       + "'," +
                     "'" + Last     + "'," +
                     "'" + Title    + "'," +
                     "'" + Address1 + "'," +
                     "'" + Address2 + "'," +
                     "'" + City     + "'," +
                     "'" + State    + "'," +
                     "'" + Zip      + "'," +
                     "'" + Email    + "'," +
                     "'" + Phone    + "')";

            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = statement;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            int retValue = command.ExecuteNonQuery();

            //if (ID == MySQLUtils.NullID)//created new entry - read last ID to get new ID
            //{
            //    command.CommandText = "SELECT ID FROM People";
            //    SqlDataReader IDs = command.ExecuteReader();

            //    int newID = 0;
            //    while (IDs.HasRows)
            //    {
            //        newID = int.Parse(IDs[0].ToString());
            //        IDs.Read();
            //    }

            //    ID = newID;
            //}

            connection.Close();

            return retValue;
        }

        public int Set()
        {
            String statement;
            statement = "UPDATE People SET " +
                    "First = '" + First + "' " +
                    "MI = '" + MI + "' " +
                    "Last = '" + Last + "' " +
                    "Title = '" + Title + "' " +
                    "Address1 = '" + Address2 + "' " +
                    "Address2 = '" + Address1 + "' " +
                    "City = '" + City + "' " +
                    "State = '" + State + "' " +
                    "Zip = '" + Zip + "' " +
                    "Email = '" + Email + "' " +
                    "Phone = '" + Phone + "' " +
                    "WHERE ID = '" + ID + "'";

            
            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = statement;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            int retValue = command.ExecuteNonQuery();

            connection.Close();

            return retValue;
        }
    }
}
