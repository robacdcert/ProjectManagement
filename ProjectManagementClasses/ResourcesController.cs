using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class ResourcesController
    {
        private readonly AppDbContext _context = new AppDbContext();

        public List<Resources> GetResources()
        {
            return _context.Resources.ToList();
        }

        public Resources GetResources(int id)
        {
            return _context.Resources.Find(id);
        }

        public Resources AddResources(Resources resources)
        {
            _context.Resources.Add(resources);
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 0)
            {
                throw new Exception("Add resources failed");
            }
            return resources;
        }

        public void DeleteResources(int id)
        {
            var resources = GetResources(id);
            if (resources is null)
            {
                throw new Exception("Resources Failed");
            }
            _context.Resources.Remove(resources);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("DeleteVendor Failed");
            }
        }
        public void UpdateResources(Resources vendor)
        {
            _context.Entry(vendor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Update Vendor Failed");
            }
        }

    }
}
