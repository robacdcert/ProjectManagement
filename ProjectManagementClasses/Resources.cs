using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class Resources
    {
        public int Id { get; set; } = 0;
        public int ProjectsId { get; set; } 
        public virtual Projects? Projects { get; set; }
        public string Name { get; set; } = string.Empty;
        public int HoursPerDay { get; set; }

    }
}
