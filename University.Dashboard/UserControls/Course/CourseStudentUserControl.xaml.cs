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

namespace University.Dashboard.UserControls.User
{
    /// <summary>
    /// Interaction logic for CourseStudentUserControl.xaml
    /// </summary>
    public partial class CourseStudentUserControl : UserControl
    {
        public CourseStudentUserControl()
        {
            InitializeComponent();
        }

        private void StudentCourseBtn_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hozirda bu malumotni korish imkoni mavjud emas!");
        }
    }
}
