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
        AppDbContext _context = new AppDbContext();

        public List<Projects> GetProjects()
        {
            return _context.Projects.ToList();
        }

        public Projects GetProjects(int id)
        {
            return _context.Projects.Find(id)!;
        }

        public Projects AddProjects(Projects projects)
        {
            _context.Projects.Add(projects);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Add project failed!");
            }
            return projects;
        }

        public void UpdateProjects(Projects projects)
        {
            _context.Entry(projects).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Update projects failed!");
            }
        }

        public void DeleteProjects(int Id)
        {
            var projects = GetProjects(Id);
            if (projects is null)
            {
                throw new Exception("Projects not found!");
            }
            _context.Projects.Remove(projects);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Delete projects failed!");
            }
        }
    }
}
