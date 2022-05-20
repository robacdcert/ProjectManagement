using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class Work
    {
        public static int Id { get; set; } = 0;
        public static int ProjectId { get; set; } = 0;
        public virtual Projects? Projects { get; set; }

    }
}
