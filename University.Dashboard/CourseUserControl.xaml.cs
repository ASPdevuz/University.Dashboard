using System;
using System.Collections.Generic;
using System.Linq;
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
using University.Dashboard.UserControls.User;

namespace University.Dashboard
{
    /// <summary>
    /// Interaction logic for CourseUserControl.xaml
    /// </summary>
    public partial class CourseUserControl : UserControl
    {
        public CourseUserControl()
        {
            InitializeComponent();
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
    }
}
