using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class Resources
    {
        public static int Id { get; set; } = 0;
        public static int ProjectId { get; set; } 
        public virtual Projects? Projects { get; set; }
        public static string Name { get; set; } = string.Empty;
        public static int HoursPerDay { get; set; } = 0;

    }
}
