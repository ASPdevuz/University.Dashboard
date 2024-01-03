using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using University.Dashboard.UserControls.Settings;
using University.Dashboard.UserControls.Student;
using University.Dashboard.UserControls.Teacher;

namespace University.Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DashboardUserControl userControl = new DashboardUserControl();
            AddUserControl(userControl);
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
            => this.Close();

        public void AddUserControl(UserControl userControl)
        {
            MenuPanel.Children.Clear();
            MenuPanel.Children.Add(userControl);
        }
        private void DashboardbtnClick(object sender, RoutedEventArgs e)
        {
            DashboardUserControl userControl = new DashboardUserControl();
            AddUserControl(userControl);
        }

        private void Coursebtn_click(object sender, RoutedEventArgs e)
        {
            CourseUserControl userControl = new CourseUserControl();
            AddUserControl(userControl);
        }

        private void Studentbtn_click(object sender, RoutedEventArgs e)
        {
            StudentUserControl userControl = new StudentUserControl();
            AddUserControl(userControl);
        }

        private void Teacherbtn_click(object sender, RoutedEventArgs e)
        {
            TeacherUserControl userControl = new TeacherUserControl();
            AddUserControl(userControl);
        }

        private void Settingsbtn_Click(object sender, RoutedEventArgs e)
        {
            SettingsUserControl userControl = new SettingsUserControl();
            AddUserControl(userControl);
        }
    }
}