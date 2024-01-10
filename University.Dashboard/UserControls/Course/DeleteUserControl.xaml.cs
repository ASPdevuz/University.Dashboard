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

namespace University.Dashboard.UserControls.User
{
    /// <summary>
    /// Interaction logic for DeleteUserControl.xaml
    /// </summary>
    public partial class DeleteUserControl : UserControl
    {
        HttpClient client = new HttpClient();
        public DeleteUserControl()
        {
            client.BaseAddress = new Uri("http://localhost:5000/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
        }
        public async void DeleteCourse(Guid id)
        {
            var responce = await client.DeleteAsync($"Course/Course/Delete/{id}");
            responce.EnsureSuccessStatusCode();
        }

        private void DeleteCoursebtn_Click(object sender, RoutedEventArgs e)
        {
            if(DeleteIdtxt.Text is not null)
            {
                try
                {
                    var id = Guid.Parse(DeleteIdtxt.Text);
                    this.DeleteCourse(id);
                    MessageBox.Show("Send to server");
                }
                catch(HttpRequestException ex)
                {
                    MessageBox.Show($"An error occured {ex}");
                }
            }
        }
    }
}
