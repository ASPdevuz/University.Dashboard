using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Dashboard.UserControls.Course.Model
{
    public class CourseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Level { get; set; }
        public string Duration { get; set; }
        public string Students { get; set; }
    }
}
