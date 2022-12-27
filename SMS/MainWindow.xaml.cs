using SMS.Models;
using SMS.Services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace SMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentService _studentService = new StudentService();
        public Teacher TeacherData { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            studentDataGrid.ItemsSource = _studentService.GetStudentList();
            studentDataGrid.IsReadOnly = true;
            userLbl.Content = $"User: {TeacherData.Name + " " + TeacherData.Surname}";
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
    }
}
