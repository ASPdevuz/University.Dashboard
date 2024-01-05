using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Dashboard.UserControls.Student.Model
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Direction { get; set; }
        public int Degree { get; set; }
        public int FacultyId { get; set; }
        public string CourseName { get; set; }
    }
}
