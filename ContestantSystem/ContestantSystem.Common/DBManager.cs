using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Common
{
    public static class DBManager
    {
        public static IDbConnection DbConnect()
        {
            IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ContestantDB"].ConnectionString);
            return connection;
        }


        public static string GetConnectionStringName { get; private set; } = ConfigurationManager.ConnectionStrings["ContestantDB"].Name;
    }
}
