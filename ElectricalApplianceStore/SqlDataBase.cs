using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalApplianceStore
{
    public class SqlDataBase
    {
        public static string connectionString;
        private static SqlConnection instance;
        private SqlDataBase() { }
        public static SqlConnection Instance()
        {
            if(connectionString != null)
            {
                if (instance == null)
                {
                    instance = new SqlConnection(connectionString);
                    instance.Open();
                }
                return instance;
            }
            return null;
        }
    }
}
