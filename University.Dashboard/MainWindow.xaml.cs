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
    }
}