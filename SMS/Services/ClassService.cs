using SMS.Models;
using System.Collections.Generic;

namespace SMS.Services
{
    public class ClassService
    {
        public ClassService() {}

        public List<Class> GetClassesList()
        {
            return new List<Class>
            {
                new Class { Code = "CL1043", Subject = "English Language" },
                new Class { Code = "CL2963", Subject = "Mathematics" },
                new Class { Code = "CL9075", Subject = "Biology" },
                new Class { Code = "CL4753", Subject = "Physics" },
                new Class { Code = "CL2288", Subject = "Chemistry" },
                new Class { Code = "CL1752", Subject = "Economics" },
                new Class { Code = "CL2533", Subject = "Computer Science" },
                new Class { Code = "CL3065", Subject = "Physical Education" },
                new Class { Code = "CL7388", Subject = "Business" },
                new Class { Code = "CL3510", Subject = "Health & Social Care" }
            };
        }
    }
}
