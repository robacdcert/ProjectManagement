using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ProjectManagementClasses
{
    public class ProjectsController
    {
        public string ConnectionString { get; set; }
        public SqlConnection SqlConnection { get; set; }

        public List<Projects> GetAllProjects()
        {
            var projects = new List<Projects>();
            var sql = "Select * from Projects";
            var cmd = new SqlCommand(sql, SqlConnection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var project = new Projects();
                project.Id = Convert.ToInt32(reader["Id"]);
                project.Description = Convert.ToString(reader["Description"]);
                project.EstimatedHours = Convert.ToInt32(reader["EstimatedHours"]);
                project.ActualHours = Convert.ToInt32(reader["ActualHours"]);
                project.Status = Convert.ToString(reader["Status"]);
            }

            reader.Close();
            SqlConnection.Close();
            return projects;
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

        public ProjectsController(string ServerInstance, string Database)
        {
            ConnectionString = $"server={ServerInstance};" +
                               $"database={Database};" +
                               "TrustServerCertificate=True;" +
                               "trusted_connection=true;";
        }
    }
}
