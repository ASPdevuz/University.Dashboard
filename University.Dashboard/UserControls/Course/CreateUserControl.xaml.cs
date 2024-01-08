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
    /// Interaction logic for CreateUserControl.xaml
    /// </summary>
    public partial class CreateUserControl : UserControl
    {
        HttpClient client = new HttpClient();
        public CreateUserControl()
        {
            client.BaseAddress = new Uri("http://localhost:5000/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
        }
        public async void CreateCourse(CreateCourseDto newCourse)
        {
            var responce = await client.PostAsJsonAsync("Course", newCourse);
            responce.EnsureSuccessStatusCode();
        }

        private void CreateCoursebtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = CourseLaveltxt.SelectedItem as ComboBoxItem;
            var levelDouble = Convert.ToDouble(selectedItem.Content.ToString());
            var newCourse = new CreateCourseDto
            {
                Name = CourseNametxt.Text,
                Level = levelDouble,
                Duration = CourseDurationtxt.Text
            };
            if(newCourse != null)
            {
                CreateCourse(newCourse);
                MessageBox.Show("Send to Server!");
            }
            else
            {
                MessageBox.Show("Null reference!");
            }    
        }
    }
}
