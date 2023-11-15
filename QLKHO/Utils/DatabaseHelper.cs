using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLKHO.Utils
{
    class DatabaseHelper
    {
        public static string Severver;
        public static string DbName;
        public static string UserId;
        public static string password;

        public static SqlConnection getConnection()
        {
            return new SqlConnection("server =" + Severver + "; Initial Catalog =" + DbName + "; uid =" + UserId + "; pwd =" + password);
        }
    }
}
