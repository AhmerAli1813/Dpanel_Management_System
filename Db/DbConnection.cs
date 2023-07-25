using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpanel_Management_System.Db
{
    public abstract class DbConnection
    {
        private readonly string ConnectionStrings;
        public DbConnection()
        {
            ConnectionStrings = "Data Source=DESKTOP-3OKF36U\\MSSQLSERVER01;Initial Catalog=POSDb;Integrated Security=True;MultipleActiveResultSets=True;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionStrings);
        }
    }
}
