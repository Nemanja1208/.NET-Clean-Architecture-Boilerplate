using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database
{
    public class DummyApplicationDatabase
    {
        public List<User> Users
        {
            get { return allUsers; }
            set { allUsers = value; }
        }

        private static List<User> allUsers = new List<User>
        {
            new User { Id = 1, Name = "Admin", CreatedAt = DateTime.Now },
            new User { Id = 2, Name = "User", CreatedAt = DateTime.Now },
            new User { Id = 3, Name = "Developer", CreatedAt = DateTime.Now },
            new User { Id = 4, Name = "Manager", CreatedAt = DateTime.Now },
            new User { Id = 5, Name = "Architect", CreatedAt = DateTime.Now }
            // Add more users if needed...
        };
    }
}
