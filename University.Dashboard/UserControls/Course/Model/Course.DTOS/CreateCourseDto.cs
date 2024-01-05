using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Dashboard.UserControls.Course.Model.Course.DTOS
{
    public class CreateCourseDto
    {
        public string Name { get; set; }
        public double Level { get; set; }
        public string Duration { get; set; }
    }
}
