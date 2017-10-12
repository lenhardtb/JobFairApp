using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFairApp.Classes
{
    public class Candidate : ISQLObject<Candidate>
    {
        public int ID = MySQLUtils.NullID;
        public int PersonID = MySQLUtils.NullID;

        public Person Person
        {
            get
            {
                return new Person().FromID(PersonID);
            }
            set
            {
                PersonID = value.ID;
            }
        }

        public Candidate FromID(int ID)
        {
            String query = "SELECT * FROM Candidates WHERE ID = '" + ID + "'";

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

        public Candidate FromDataReader(SqlDataReader reader)
        {
            ID = reader.GetInt32(reader.GetOrdinal("ID"));
            PersonID = reader.GetInt32(reader.GetOrdinal("PersonID"));

            reader.Read();//advance reader because it may have other records

            return this;
        }

        public Candidate FromDataRow(DataRow row)
        {
            ID = (int)row["ID"];
            PersonID = (int)row["PersonID"];

            return this;
        }

        public int Insert()
        {
            if (ID == MySQLUtils.NullID || PersonID == MySQLUtils.NullID) return 0;

            String statement;
            statement = "INSERT INTO Candidates (PersonID) VALUES" +
                    "(" + PersonID + ")";


            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = statement;
            command.CommandType = CommandType.Text;

            int retValue = command.ExecuteNonQuery();

            ////created new entry, read new ID
            //if(ID == MySQLUtils.NullID)
            //{
            //    command.CommandText = "SELECT ID FROM Candidates";

            //    SqlDataReader reader = command.ExecuteReader();

            //    while(reader.HasRows)
            //    {
            //        ID = (int)reader[0];
            //        reader.Read();
            //    }
            //}

            connection.Close();

            return retValue;
        }

        public int Set()
        {
            if (ID == MySQLUtils.NullID || PersonID == MySQLUtils.NullID) return 0;
            

            String statement;
            statement = "UPDATE Candidates SET " +
                    "PersonID = '" + PersonID + "' " +
                    "WHERE ID = '" + ID + "'";
            

            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = statement;
            command.CommandType = CommandType.Text;

            int retValue = command.ExecuteNonQuery();

            connection.Close();

            return retValue;
        }
    }//class(Candidate)
}//namespace
