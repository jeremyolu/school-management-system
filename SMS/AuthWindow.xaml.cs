using SMS.Services;
using System;
using System.Linq;
using System.Windows;

namespace SMS
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private readonly TeacherService _teacherService = new TeacherService();

        public AuthWindow()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string userId = userIdTxtBox.Text;
            string password = passwordTxtBox.Password;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login credentials have not been supplied.", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var teachers = _teacherService.GetTeachers();

                var teacher = teachers.FirstOrDefault(t => t.Id.Equals(Convert.ToInt32(userId)) && t.Password.Equals(password));

                if (teacher != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.TeacherData = teacher;
                    mainWindow.Show();

                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Try again.", "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
