using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Dashboard.UserControls.Course.Model.Course.DTOS
{
    public class GetCourseDto
    {
        public GetCourseDto(CourseModel entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Level = entity.Level;
            Duration = entity.Duration;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Level { get; set; }
        public string Duration { get; set; }
    }
}
