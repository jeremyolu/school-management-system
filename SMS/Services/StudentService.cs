using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SMS.Services
{
    public class StudentService
    {
        private readonly TeacherService _teacherService;

        public StudentService()
        {
            _teacherService = new TeacherService();
        }

        public List<Student> GetStudentsList()
        {
            var studentInfo = GetStudentInfoList();

            return new List<Student>
            {
                new Student { Id = 1001, Firstname = "Jeremy", MiddleName = "Alan", Surname = "Smith", Sex = Sex.Male, ImageSrc = "male.png", 
                    Dob = new DateTime(2005, 05, 14), Ethnicity = Ethnicity.Black, StudentInfo = studentInfo.FirstOrDefault(s => s.StudentId == 1001) },
                new Student { Id = 1002, Firstname = "Abu", MiddleName = "Abdullah", Surname = "Khan", Sex = Sex.Male, ImageSrc = "male.png", 
                    Dob = new DateTime(2006, 03, 27), Ethnicity = Ethnicity.Asian, StudentInfo = studentInfo.FirstOrDefault(s => s.StudentId == 1002) },
                new Student { Id = 1003, Firstname = "Lilly", MiddleName = "Kelly", Surname = "Graham", Sex = Sex.Female, ImageSrc = "female.png", 
                    Dob = new DateTime(2005, 01, 22), Ethnicity = Ethnicity.White, StudentInfo = studentInfo.FirstOrDefault(s => s.StudentId == 1003) }
            };
        }

        public Student GetStudent(int studentId)
        {
            return GetStudentsList().FirstOrDefault(s => s.Id == studentId);
        }

        private List<StudentInfo> GetStudentInfoList()
        {
            var teachers = _teacherService.GetTeachers();

            return new List<StudentInfo>
            {
                new StudentInfo { StudentId = 1001, YearGroup = 12, IsSpecialNeeds = false,
                    Notes = "Tends to forget homework, extra caution should be taken", Tutor = teachers.FirstOrDefault(t => t.TeacherInfo.YearGrp == 12) },

                new StudentInfo { StudentId = 1002, YearGroup = 12, IsSpecialNeeds = false, 
                    Notes = "Gifted and talented student, should be achieving level 6 and higher", Tutor = teachers.FirstOrDefault(t => t.TeacherInfo.YearGrp == 12) },

                new StudentInfo { StudentId = 1003, YearGroup = 13, IsSpecialNeeds = true, 
                    Notes = "Child requires special needs with reading and writing", Tutor = teachers.FirstOrDefault(t => t.TeacherInfo.YearGrp == 13) }
            };
        }
    }
}
