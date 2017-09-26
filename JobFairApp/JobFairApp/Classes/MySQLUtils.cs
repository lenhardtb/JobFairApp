using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFairApp.Classes
{
    public class MySQLUtils
    {
        public const String ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JobFair;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const int NullID = -1;
    }
}
