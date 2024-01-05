using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using University.Dashboard.UserControls.Course.Interface;
using University.Dashboard.UserControls.Course.Model;
using University.Dashboard.UserControls.Course.Model.Course.DTOS;

namespace University.Dashboard.UserControls.Course.Repositories
{
    public class CourseService : ICourse
    {
        private readonly HttpClient client;

        public CourseService(HttpClient client)
        {
            this.client = client;
        }
        public async void CreateCourse(CreateCourseDto newCourse)
        {
            var responce = await client.PostAsJsonAsync("Course", newCourse);
            responce.EnsureSuccessStatusCode();
        }

        public async void DeleteCourse(Guid id)
        {
            var responce = await client.DeleteAsync($"Course/{id}");
            responce.EnsureSuccessStatusCode();
        }

        public async Task<List<CourseModel>> GetCources()
        {
            var response = await client.GetAsync("Course");
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                List<CourseModel> courses = await response.Content.ReadFromJsonAsync<List<CourseModel>>();
                return courses;
            }
            else
            {
                return null;
            }
        }

        public async void GetCuorse(Guid id)
        {
            var responce = await client.GetAsync($"Course/{id}");
            responce.EnsureSuccessStatusCode();
        }

        public async void UpdateCourse(Guid id, UpdateCourseDto dto)
        {
            var responce = await client.PutAsJsonAsync($"Course/{id}", dto);
            responce.EnsureSuccessStatusCode();
        }
    }
}
