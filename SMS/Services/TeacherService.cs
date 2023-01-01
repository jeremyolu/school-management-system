using SMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace SMS.Services
{
    public class TeacherService
    {
        private readonly ClassService _classService;

        public TeacherService()
        {
            _classService = new ClassService();
        }

        public List<Teacher> GetTeachers()
        {
            return new List<Teacher> 
            { 
                new Teacher { Id = 1000, Title = "Mr", Name = "Dave", Surname = "Gill", TeacherInfo = GetTeachersInfo().FirstOrDefault(t => t.Id == 1000 ) },
                new Teacher { Id = 1001, Title = "Ms", Name = "Karen", Surname = "Summers", TeacherInfo = GetTeachersInfo().FirstOrDefault(t => t.Id == 1001 ) },
                new Teacher { Id = 1002, Title = "Mr", Name = "Gary", Surname = "Bold", TeacherInfo = GetTeachersInfo().FirstOrDefault(t => t.Id == 1002 ) },
                new Teacher { Id = 1003, Title = "Mr", Name = "Shabi", Surname = "Kandule", TeacherInfo = GetTeachersInfo().FirstOrDefault(t => t.Id == 1003 )  }
            };
        }

        private List<TeacherInfo> GetTeachersInfo()
        {
            var classes = _classService.GetClassesList();

            return new List<TeacherInfo>()
            {
                new TeacherInfo
                {
                    Id = 1000,
                    Password = "password",
                    IsAdmin = true,
                    YearGrp = 12,
                    AssignedClasses = classes
                },

                new TeacherInfo
                {
                    Id = 1001,
                    Password = "password",
                    IsAdmin = true,
                    YearGrp = 12,
                    AssignedClasses = classes
                },

                new TeacherInfo
                {
                    Id = 1002,
                    Password = "password",
                    IsAdmin = true,
                    YearGrp = 13,
                    AssignedClasses = classes
                },

                new TeacherInfo
                {
                    Id = 1003,
                    Password = "password",
                    IsAdmin = false,
                    YearGrp = 12,
                    AssignedClasses = classes
                }
            };
        }
    }
}