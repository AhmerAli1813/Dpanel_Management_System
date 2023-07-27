using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpanel_Management_System.Db
{
    public abstract class DbConnection
    {
        
        //create Database connection variable 
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);




        private string s = File.ReadAllText(path + "\\connect");

        
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(s);
        }
    }
}
