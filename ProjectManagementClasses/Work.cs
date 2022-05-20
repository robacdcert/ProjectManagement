using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class Work
    {
        public int Id { get; set; } = 0;
        public int ProjectsId { get; set; } = 0;
        public virtual Projects? Projects { get; set; }
        public int ResourcesId { get; set; }
        public virtual Resources? Resources { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Hours { get; set; } = 0;


    }
}
