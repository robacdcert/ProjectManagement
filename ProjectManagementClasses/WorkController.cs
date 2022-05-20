using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class WorkController
    {
        AppDbContext _context = new AppDbContext();

        public List<Work> GetWorks()
        {
            return _context.Work.ToList();
        }

        public Work GetWork(int id)
        {
            return _context.Work.Find(id);
        }

        public Work RecordWork(Work work)
        {
            _context.Work.Add(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Recording work failed!");
            }
            return work;
        }

        public void UpdateWork(Work work)
        {
            _context.Entry(work).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Update work failed!");
            }
        }

        public void DeleteWork(int Id)
        {
            var work = GetWork(Id);
            if (work is null)
            {
                throw new Exception(" not found!");
            }
            _context.Work.Remove(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Delete work failed!");
            }
        }
    }
}
