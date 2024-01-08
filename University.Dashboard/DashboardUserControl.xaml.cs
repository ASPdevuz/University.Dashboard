using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
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
using University.Dashboard.UserControls.Course.Model;
using University.Dashboard.UserControls.Course.Repositories;

namespace University.Dashboard
{
    /// <summary>
    /// Interaction logic for DashboardUserControl.xaml
    /// </summary>
    public partial class DashboardUserControl : UserControl
    {
        HttpClient client = new HttpClient();
        public DashboardUserControl()
        {
            client.BaseAddress = new Uri("http://localhost:5000/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
        }
        public async void GetCources()
        {
            var response = await client.GetStringAsync("Course/Courses");

            if (response != null)
            {
                CourseDB.DataContext = JsonConvert.DeserializeObject<List<CourseModel>>(response);
            }
            else
            {
                return;
            }
        }
        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            GetCources();
        }
    }
}
