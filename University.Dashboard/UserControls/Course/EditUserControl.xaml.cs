using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using University.Dashboard.UserControls.Course.Model.Course.DTOS;

namespace University.Dashboard.UserControls.User
{
    /// <summary>
    /// Interaction logic for EditUserControl.xaml
    /// </summary>
    public partial class EditUserControl : UserControl
    {
        HttpClient client = new HttpClient();
        public EditUserControl()
        {
            client.BaseAddress = new Uri("http://localhost:5000/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
        }

        public async void UpdateCourse(Guid id, UpdateCourseDto dto)
        {
            try
            {
                var responce = await client.PutAsJsonAsync($"Course/Course/Update/{id}", dto);
                responce.EnsureSuccessStatusCode();
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show($"An error occured {ex}");
            }
        }

        private void EditCoursebtn_Click(object sender, RoutedEventArgs e)
        {
            var id = Guid.Parse(CourseIdtxt.Text);
            var selectedItem = CourseLaveltxt.SelectedItem as ComboBoxItem;
            var levelToDouble = Convert.ToDouble(selectedItem.Content.ToString());
            var course = new UpdateCourseDto
            {
                Name = CourseNametxt.Text,
                Level = levelToDouble,
                Duration = CourseDurationtxt.Text
            };

            if(course != null)
            {
                this.UpdateCourse(id, course);
                MessageBox.Show("Send to server!");
            }
            else
            {
                MessageBox.Show("Null reference");
            }
        }
    }
}
