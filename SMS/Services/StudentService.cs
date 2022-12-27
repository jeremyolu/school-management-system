using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SMS.Services
{
    public class StudentService
    {
        public List<StudentViewModel> GetStudentList()
        {
            var students = GetStudents();

            var studentViewModelList = new List<StudentViewModel>();

            foreach (var student in students)
            {
                var studentView = new StudentViewModel
                {
                    StudentId = student.Id,
                    Firstname = student.Firstname,
                    Surname = student.Surname,
                    StudentInfo = student.StudentInfo,
                    Dob = student.Dob.ToShortDateString()
                };

                studentViewModelList.Add(studentView);
            }

            return studentViewModelList;
        }

        private List<Student> GetStudents()
        {
            var studentInfo = GetStudentInfoList();

            return new List<Student>
            {
                new Student { Id = 1001, Firstname = "Jeremy", Surname = "Smith", Sex = Sex.Male, Dob = new DateTime(2005, 05, 14), Ethnicity = Ethnicity.Black, StudentInfo = studentInfo.FirstOrDefault(s => s.StudentId == 1001)  },
                new Student { Id = 1002, Firstname = "Abu", Surname = "Khan", Sex = Sex.Male, Dob = new DateTime(2006, 03, 27), Ethnicity = Ethnicity.Asian, StudentInfo = studentInfo.FirstOrDefault(s => s.StudentId == 1002)},
                new Student { Id = 1003, Firstname = "Lilly", Surname = "Graham", Sex = Sex.Female, Dob = new DateTime(2005, 01, 22), Ethnicity = Ethnicity.White, StudentInfo = studentInfo.FirstOrDefault(s => s.StudentId == 1003) }
            };
        }

        private List<StudentInfo> GetStudentInfoList()
        {
            return new List<StudentInfo>
            {
                new StudentInfo { StudentId = 1001, Age = 18, Tutor = "Mr McGowan", YearGroup = "12", IsSpecialNeeds = false, Notes = "Tends to forget homework, extra caution should be taken" },
                new StudentInfo { StudentId = 1002, Age = 19, Tutor = "Mr Stephenson", YearGroup = "12", IsSpecialNeeds = false, Notes = "Gifted and talented student, should be achieving level 6 and higher" },
                new StudentInfo { StudentId = 1003, Age = 18, Tutor = "Mrs Allen", YearGroup = "13", IsSpecialNeeds = true, Notes = "Child requires special needs with reading and writing" }
            };
        }
    }

    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Dob { get; set; }
        public StudentInfo StudentInfo { get; set; }
    }
}
