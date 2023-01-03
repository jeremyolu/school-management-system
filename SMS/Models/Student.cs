using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Firstname} {MiddleName} {Surname}";
        public Sex Sex { get; set; }
        public DateTime Dob { get; set; }
        public int Age => DateTime.Now.Year - Dob.Year;
        public Ethnicity Ethnicity { get;set; }
        public string Address { get;set; }
        public string ImageSrc { get;set; }
        public StudentInfo StudentInfo { get; set; }
    }

    public class StudentInfo
    {
        public int StudentId { get; set; }
        public int YearGroup { get; set; }
        public bool IsSpecialNeeds { get; set; }
        public string Notes { get; set; }
        public Teacher Tutor { get; set; }
        public Parent Parent { get; set; }
        public List<Class> Classes { get; set; }
    }
}
