using SMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace SMS.Services
{
    public class ParentService
    {

        public List<Parent> GetParentsList()
        {
            return new List<Parent>
            {
                new Parent{ Id = 1001, Title = Title.Mr, Name = "Andy", Surname = "Smith", ParentInfo = GetParentInfo().FirstOrDefault(p => p.Id == 1001 ) },
                new Parent{ Id = 1002, Title = Title.Miss, Name = "Karen", Surname = "Graham", ParentInfo = GetParentInfo().FirstOrDefault(p => p.Id == 1002 ) },
                new Parent{ Id = 1003, Title = Title.Mrs, Name = "Latifah", Surname = "Khan", ParentInfo = GetParentInfo().FirstOrDefault(p => p.Id == 1003 ) },
            };
        }

        private List<ParentInfo> GetParentInfo()
        {
            return new List<ParentInfo>
            {
                new ParentInfo{ Id = 1001, Relationship = Relationship.Father,
                    Address = "22 Powey Lane, Enfield London, EN3 7PZ", Phone = "07865432189", Email = "andy.smith@aol.com" },

                new ParentInfo{ Id = 1002, Relationship = Relationship.Mother,
                    Address = "35b Monoux Lane, Walthamstow E17 5SB", Phone = "07543278987", Email = "karen-graham79@gmail.com"},

                new ParentInfo{ Id = 1003, Relationship = Relationship.Mother, 
                    Address = "12A Dendon Drive, Clapton E5 3CQ", Phone = "07792365890", Email = "latifah-khan@outlook.com" }
            };
        }
    }
}
