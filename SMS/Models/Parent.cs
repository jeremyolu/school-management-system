using System.Collections.Generic;

namespace SMS.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public Title Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
        public ParentInfo ParentInfo { get; set; }
    }

    public class ParentInfo
    {
        public int Id { get; set; }
        public Relationship Relationship { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Student Child { get; set; }
    }
}
