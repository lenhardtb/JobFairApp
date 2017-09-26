using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFairApp.Classes
{
    public class Interview : ISQLObject<Interview>
    {
        public int ID;
        public int CandidateID;
        public int JobFairID;
        public int TimeSlotID;
        public int TableID;

        public Interview FromID(int ID)
        {
            throw new NotImplementedException();
        }

        public Interview FromDataReader(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public Interview FromDataRow(DataRow row)
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
    }
}
