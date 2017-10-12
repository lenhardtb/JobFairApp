using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace JobFairApp.Classes
{
    public class JobFair : ISQLObject<JobFair>
    {
        public int ID;
        public String Name;
        public String Description;
        public String StartDate;
        public String EndDate;
        public String Website;
        public String Phone;
        public int ContactPersonID;

        public Person ContactPerson
        {
            get
            {
                return new Person().FromID(ContactPersonID);
            }
            set
            {
                ContactPersonID = value.ID;
            }
        }

        public JobFair FromID(int ID)
        {
            String query = "SELECT * FROM JobFairs WHERE ID = '" + ID + "'";

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

        public JobFair FromDataReader(SqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                ID = MySQLUtils.NullID;
                Name = null;
                Description = null;
                StartDate = null;
                EndDate = null;
                Website = null;
                Phone = null;
                ContactPersonID = MySQLUtils.NullID;

                return this;
            }

            ID = reader.GetInt32(reader.GetOrdinal("ID"));
            Name = (String)reader["Name"];
            Description = (String)reader["Description"];
            StartDate = (String)reader["StartDate"];
            EndDate = (String)reader["EndDate"];
            Website = (String)reader["Website"];
            Phone = (String)reader["Phone"];
            ContactPersonID = (int)reader["ContactPersonID"];

            reader.Read();//advance reader because it may have other records

            return this;
        }

        public JobFair FromDataRow(DataRow row)
        {
            ID = (int)row["ID"];
            Name = (String)row["Name"];
            Description = (String)row["Description"];
            StartDate = (String)row["StartDate"];
            EndDate = (String)row["EndDate"];
            Website = (String)row["Website"];
            Phone = (String)row["Phone"];
            ContactPersonID = (int)row["ContactPersonID"];

            return this;
        }

        public int Insert()
        {
            String statement;
            statement = "INSERT INTO JobFairs " +
                    "(Name, Description, StartDate, EndDate, " +
                    "Website, Phone, ContactPersonID) VALUES" +
                     "(" +
                     "'" + Name + "'," +
                     "'" + Description + "'," +
                     "'" + StartDate + "'," +
                     "'" + EndDate + "'," +
                     "'" + Website + "'," +
                     "'" + Phone + "'," +
                     "'" + ContactPersonID + "')";

            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = statement;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            int retValue = command.ExecuteNonQuery();

            //if (ID == MySQLUtils.NullID)//created new entry - read last ID to get new ID
            //{
            //    command.CommandText = "SELECT ID FROM JobFairs";
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
            statement = "UPDATE JobFairs SET" +
                    "(Name, Description, StartDate, EndDate, " +
                    "Website, Phone, ContactPersonID) VALUES" +
                     "(" +
                     "'" + Name + "'," +
                     "'" + Description + "'," +
                     "'" + StartDate + "'," +
                     "'" + EndDate + "'," +
                     "'" + Website + "'," +
                     "'" + Phone + "'," +
                     "'" + ContactPersonID + "')" +
                     "WHERE ID = '" + ID + "'";

            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = statement;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            int retValue = command.ExecuteNonQuery();

            //if (ID == MySQLUtils.NullID)//created new entry - read last ID to get new ID
            //{
            //    command.CommandText = "SELECT ID FROM JobFairs";
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
    }
}
