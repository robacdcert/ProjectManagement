using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class ResourcesController
    {
        public string ConnectionString { get; set; }
        public SqlConnection SqlConnection { get; set; }

        public List<Resources> GetAllProjects()
        {
            var resources = new List<Resources>();
            var sql = "Select * from Resources";
            var cmd = new SqlCommand(sql, SqlConnection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var resource = new Resources();
                resource.Id = Convert.ToInt32(reader["Id"]);
                resource.ProjectsId = Convert.ToInt32(reader["ProjectId"]);
                resource.Name = Convert.ToString(reader["Name"]);
                resource.HoursPerDay = Convert.ToInt32(reader["HoursPerDay"]);
            }

            reader.Close();
            SqlConnection.Close();
            return resources;
        }

        public void CloseConnection()
        {
            SqlConnection.Close();
        }

        public ResourcesController(string ServerInstance, string Database)
        {
            ConnectionString = $"server={ServerInstance};" +
                               $"database={Database};" +
                               "TrustServerCertificate=True;" +
                               "trusted_connection=true;";
        }
    }
}
