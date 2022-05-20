using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class WorkController
    {
        public string ConnectionString { get; set; }
        public SqlConnection SqlConnection { get; set; }















        public void OpenConnection()
        {
            SqlConnection = new SqlConnection(ConnectionString);
            SqlConnection.Open();
            if (SqlConnection.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Connection did not open");
            }

        }

        public void CloseConnection()
        {
            SqlConnection.Close();
        }


        public WorkController(string ServerInstance, string Database)
        {
            ConnectionString = $"server = {ServerInstance};"
                                + $"database = {Database};"
                                + "TrustServerCertificate=true;"
                                + "trusted_connection=true;";
        }
    }
}
