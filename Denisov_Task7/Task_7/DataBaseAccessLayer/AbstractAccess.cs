using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccessLayer
{
    internal abstract class AbstractAccess
    {
        protected static SqlConnection connection;

        protected string connectionString;

        public AbstractAccess(string coonectionString)
        {
            this.connectionString = coonectionString;
        }
    }
}
