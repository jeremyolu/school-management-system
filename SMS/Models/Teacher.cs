﻿namespace SMS.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsAdmin { get; set; }
    }
}