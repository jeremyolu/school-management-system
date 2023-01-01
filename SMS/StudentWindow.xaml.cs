using SMS.Models;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Controls;

namespace SMS
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public Student Student { get; set; }

        public StudentWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            if (Student != null)
            {
                studentLbl.Text = Student.FullName;
                dobLob.Text = $"Dob: {Student.Dob.ToShortDateString()} ({Student.Age})";
                sexLbl.Text = $"Sex: {Student.Sex}";
                ethnicityLbl.Text = $"Ethnicity: {Student.Ethnicity}";
                yearGrpLbl.Text = $"Year Grp: {Student.StudentInfo.YearGroup}";
                tutorLbl.Text = $"Tutor: {Student.StudentInfo.Tutor.FullName}";
                specialNeedsLbl.Text = $"Special Needs: {Student.StudentInfo.IsSpecialNeeds}";
                studentNotesTxtBox.Text = Student.StudentInfo.Notes;
                studentImage.Source = SetImageSource(studentImage, @"D:\Dev\Programming\CSharp\Projects\WPF\SMS\SMS\Resources\" + Student.ImageSrc);

                updateStudentBtn.Content = $"Update {Student.Firstname}'s Details";
            }
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

        private void closeMenu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
