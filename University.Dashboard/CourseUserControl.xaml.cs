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
using University.Dashboard.UserControls.Course.Interface;
using University.Dashboard.UserControls.User;

namespace University.Dashboard
{
    /// <summary>
    /// Interaction logic for CourseUserControl.xaml
    /// </summary>
    public partial class CourseUserControl : UserControl
    {
        private readonly ICourse service;
        HttpClient client = new HttpClient();
        public CourseUserControl(ICourse service)
        {
            client.BaseAddress = new Uri("http://localhost:5000/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
            this.service = service;
        }
        public async void GetDB()
        {
            var courses = await service.GetCources();
            CourseDB.DataContext = courses;
        }
        private void AddUserControl(UserControl userControl)
        {
            CourseMenuPanel.Children.Clear();
            CourseMenuPanel.Children.Add(userControl);
        }
        private void Createcrs_click(object sender, RoutedEventArgs e)
        {
            CreateUserControl userControl = new CreateUserControl();
            AddUserControl(userControl);
        }

        private void Editcrs_click(object sender, RoutedEventArgs e)
        {
            EditUserControl userControl = new EditUserControl();
            AddUserControl(userControl);
        }

        private void Removecrs_click(object sender, RoutedEventArgs e)
        {
            DeleteUserControl userControl = new DeleteUserControl();
            AddUserControl(userControl);
        }

        private void Studentcrs_click(object sender, RoutedEventArgs e)
        {
            CourseStudentUserControl userControl = new CourseStudentUserControl();
            AddUserControl(userControl);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            GetDB();
        }
    }
}
