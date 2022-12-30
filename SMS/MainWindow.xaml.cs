using SMS.Models;
using SMS.Services;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentService _studentService = new StudentService();
        private readonly ClassService _classService;
        public Teacher TeacherData { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            _classService = new ClassService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            studentDataGrid.ItemsSource = _studentService.GetStudentList();
            studentDataGrid.IsReadOnly = true;

            classDataGrid.ItemsSource = _classService.GetClassesList();
            classDataGrid.IsReadOnly = true;

            if (TeacherData != null )
            {
                userLbl.Content = $"User: {TeacherData.Name + " " + TeacherData.Surname}";
            }
        }

        private void SetData(StudentViewModel selectedItem)
        {
            if (selectedItem != null)
            {
                fullNameLbl.Text = $"Name: {selectedItem.Firstname + " " + selectedItem.Surname}";
                ageLbl.Text = $"Age: {selectedItem.StudentInfo.Age}";
                yearGroupLbl.Text = $"YearGrp: {selectedItem.StudentInfo.YearGroup}";
                TutorNameLbl.Text = $"Tutor: {selectedItem.StudentInfo.Tutor}";
                specialNeedsLbl.Text = $"Special Needs: {IsSpecialNeeds(selectedItem.StudentInfo.IsSpecialNeeds)}";
                studentNotesTxtBox.Text = selectedItem.StudentInfo.Notes;

                studentImage.Source = SetImageSource(studentImage, @"D:\Dev\Programming\CSharp\Projects\WPF\SMS\SMS\Resources\" + selectedItem.ImageSrc);
            }
        }

        private void studentDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (StudentViewModel)studentDataGrid.SelectedItem;

            SetData(selectedItem);
        }

        private string IsSpecialNeeds(bool isSpecialNeeds)
        {
            return isSpecialNeeds ? "Yes" : "No";
        }

        private void addNotesBtn_Click(object sender, RoutedEventArgs e)
        {
            studentNotesTxtBox.IsReadOnly = false;
            studentNotesTxtBox.Background = new SolidColorBrush(Colors.White);
        }

        private void studentDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedItem = (StudentViewModel)studentDataGrid.SelectedItem;

            var student = _studentService.GetStudent(selectedItem.StudentId);

            if (student != null)
            {
                foreach (StudentWindow window in Application.Current.Windows.OfType<StudentWindow>())
                {
                    window.Close();
                }

                OpenStudentWindow(student);
            }
        }

        private void OpenStudentWindow(Student student)
        {
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.Title = $"{student.Firstname + " " + student.Surname + " - " + student.Id}";
            studentWindow.Student = student;
            studentWindow.Show();
        }

        public ImageSource SetImageSource(Image image, string path)
        {
            // Create a new BitmapImage and set its source to a file
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(path);
            bitmapImage.EndInit();

            // Set the Image control's source to the BitmapImage
            image.Source = bitmapImage;

            return image.Source;
        }

        private void newStudentMenu_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void closeMenu_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close SMS?", "Exit SMS", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                foreach (Window window in Application.Current.Windows)
                {
                    window.Close();
                }
            }
        }
    }
}
