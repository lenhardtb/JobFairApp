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
        public JobFair FromID(int ID)
        {
            throw new NotImplementedException();
        }

        public JobFair FromDataReader(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public JobFair FromDataRow(DataRow row)
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
