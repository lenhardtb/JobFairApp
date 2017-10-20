using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace JobFairApp.Classes
{
    class Company : ISQLObject<Company>
    {
        public int ID = MySQLUtils.NullID;
        public String name;
        public String email;
        public String phone;
        public String description;



        public Company FromID(int ID)
        {
            String query = "SELECT * FROM Companies WHERE ID = \"" + ID + "\"";

            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            SqlDataReader reader = cmd.ExecuteReader();
            connection.Close();

            return FromDataReader(reader);
        }
        public Company FromDataReader(SqlDataReader reader)
        {
            ID = reader.GetInt32(reader.GetOrdinal("ID"));
            name = reader.GetString(reader.GetOrdinal("Name"));
            description = reader.GetString(reader.GetOrdinal("Description"));
            phone = reader.GetString(reader.GetOrdinal("Phone"));
            email = reader.GetString(reader.GetOrdinal("Email"));

            reader.Read();//advance reader because it may have other records

            return this;
        }

        public Company FromDataRow(DataRow row)
        {
            ID = (int)row["ID"];
            name = (String)row["Name"];
            email = (String)row["Email"];
            phone = (String)row["Phone"];
            description = (String)row["Description"];


            return this;
        }

        public int Insert()
        {
            String statement;
            if (ID == -1)
            {
                statement = "INSERT INTO Venues (Name, Description, Phone, Email ) VALUES" +
                    "(" +
                    "'" + name + "'," +
                    "'" + description + "'," +
                    "'" + phone + " ', " +
                    " ' " + email + "')";
            }
            else
            {
                statement = "UPDATE People SET " +
                    "Name = '" + name + "'" +
                    "Description = '" + description + "'" +
                    "Phone = '" + phone + "'" +
                    "Email = '" + email + "'";
            }

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

        public int Set()
        {
            if (ID == MySQLUtils.NullID) return 0;

            String statement;
            statement = "UPDATE People SET " +
                    "Name = '" + name + "'" +
                    " Description = '" + description + "'" +
                    " Phone = '" + phone + "'"+
                    " Email = '" + email + "'";

            SqlConnection connection = new SqlConnection(MySQLUtils.ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = statement;
            command.CommandType = CommandType.Text;

            int retValue = command.ExecuteNonQuery();

            connection.Close();

            return retValue;
        }
    }
}
