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

        private Person person;
        public Person Person
        {
            get
            {
                if (PersonID != MySQLUtils.NullID)
                {
                    if (person == null)
                    {
                        person = new Person().FromID(PersonID);
                    }

                    return person;
                }
                else throw new InvalidOperationException("No PersonID found!");
            }
            set
            {
                person = value;
                PersonID = person.ID;

                //rematch ID
                String query = "SELECT ID FROM Candidates WHERE PersonID = '" + PersonID + "'";

                SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                
                ID = reader.GetInt32(0);
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
            person = null;//in case this was called on an existing object

            reader.Read();//advance reader because it may have other records

            return this;
        }

        public Candidate FromDataRow(DataRow row)
        {
            ID = (int)row["ID"];
            PersonID = (int)row["PersonID"];
            person = null;//in case this was called on an existing object

            return this;
        }

        public int Insert()
        {
            if (ID == MySQLUtils.NullID) return 0;
            if (PersonID == MySQLUtils.NullID)
            {
                if (person != null)
                    person.Insert();
                else//there's no person ... it ... it doesn't work
                {
                    return 0;
                }
                PersonID = person.ID;
            }

            String statement;
            statement = "INSERT INTO Candidates (PersonID) " +
                    "(" + PersonID + ")";


            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = statement;
            command.CommandType = CommandType.Text;

            int retValue = command.ExecuteNonQuery();

            //created new entry, read new ID
            if(ID == MySQLUtils.NullID)
            {
                command.CommandText = "SELECT ID FROM Candidates";

                SqlDataReader reader = command.ExecuteReader();

                while(reader.HasRows)
                {
                    ID = (int)reader[0];
                    reader.Read();
                }
            }

            connection.Close();

            return retValue;
        }

        public int Set()
        {
            if (ID == MySQLUtils.NullID) return 0;
            if (PersonID == MySQLUtils.NullID)
            {
                if (person != null)
                    person.Insert();
                else//there's no person ... it ... it doesn't work
                {
                    return 0;
                }
                PersonID = person.ID;
            }

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
