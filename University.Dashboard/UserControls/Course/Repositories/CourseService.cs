using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using University.Dashboard.UserControls.Course.Model;
using University.Dashboard.UserControls.Course.Model.Course.DTOS;

namespace University.Dashboard.UserControls.Course.Repositories
{
    public class CourseService
    {
        private readonly HttpClient client;

        public CourseService(HttpClient client)
        {
            this.client = client;
        }
        

        public async void DeleteCourse(Guid id)
        {
            var responce = await client.DeleteAsync($"Course/{id}");
            responce.EnsureSuccessStatusCode();
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
