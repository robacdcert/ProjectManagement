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

        public List<Work> GetAllWorks()
        {
            var works = new List<Work>();
            var sql = "Select * from Work";
            var cmd = new SqlCommand(sql, SqlConnection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var work = new Work();
                work.Id = Convert.ToInt32(reader["Id"]);
                work.ProjectsId = Convert.ToInt32(reader["ProjectId"]);
                work.ResourcesId = Convert.ToInt32(reader["ResourceId"]);
                work.Description = Convert.ToString(reader["Description"]);
                work.Hours = Convert.ToInt32(reader["Hours"]);
            }

            reader.Close();
            SqlConnection.Close();
            return works;
        }

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
