using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Dashboard.UserControls.Course.Model;
using University.Dashboard.UserControls.Course.Model.Course.DTOS;

namespace University.Dashboard.UserControls.Course.Interface
{
    public interface ICourse
    {
        Task<List<CourseModel>> GetCources();
        void GetCuorse(Guid id);
        void CreateCourse(CreateCourseDto newCourse);
        void UpdateCourse(Guid id, UpdateCourseDto dto);
        void DeleteCourse(Guid id);
    }
}
