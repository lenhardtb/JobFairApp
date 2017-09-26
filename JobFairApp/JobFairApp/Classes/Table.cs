using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFairApp.Classes
{
    public class Table : ISQLObject<Table>
    {
        public Table FromID(int ID)
        {
            throw new NotImplementedException();
        }

        public Table FromDataReader(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public Table FromDataRow(DataRow row)
        {
            throw new NotImplementedException();
        }
        
        public int Insert()
        {
            throw new NotImplementedException();
        }

        public int Set()
        {
            throw new NotImplementedException();
        }
    }//class(Table)
}//namespace
