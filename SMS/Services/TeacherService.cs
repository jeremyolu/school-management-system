using SMS.Models;
using System.Collections.Generic;

namespace SMS.Services
{
    public class TeacherService
    {
        public List<Teacher> GetTeachers()
        {
            return new List<Teacher> 
            { 
                new Teacher { Id = 1000, Title = "Mr", Name = "Dave", Surname = "Gill", Password = "password", IsAdmin = true },
                new Teacher { Id = 1001, Title = "Ms", Name = "Karen", Surname = "Summers", Password = "password", IsAdmin = true },
                new Teacher { Id = 1002, Title = "Mr", Name = "Gary", Surname = "Bold", Password = "password", IsAdmin = false },
                new Teacher { Id = 1003, Title = "Mr", Name = "Shabi", Surname = "Kandule", Password = "password", IsAdmin = false }
            };
        }
    }
}