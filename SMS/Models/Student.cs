using System;

namespace SMS.Models
{
    public enum Ethnicity
    {
        Black,
        White,
        Asian
    }

    public enum Sex
    {
        Male,
        Female,
        Other
    }

    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public Sex Sex { get; set; }
        public DateTime Dob { get; set; }
        public int Age => DateTime.Now.Year - Dob.Year;
        public Ethnicity Ethnicity { get;set; }
        public string ImageUrl { get;set; }
        public StudentInfo StudentInfo { get; set; }
    }

    public class StudentInfo
    {
        public int StudentId { get; set; }
        public string YearGroup { get; set; }
        public string Tutor { get; set; }
        public int Age { get; set; }
        public bool IsSpecialNeeds { get; set; }
        public string Notes { get; set; }
    }
}
