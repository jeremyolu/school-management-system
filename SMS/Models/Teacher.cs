using System.Collections.Generic;

namespace SMS.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Title} {Name} {Surname}";
        public TeacherInfo TeacherInfo { get; set; }
    }

    public class TeacherInfo
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public int YearGrp { get; set; }
        public List<Class> AssignedClasses { get; set; }
    }
}
