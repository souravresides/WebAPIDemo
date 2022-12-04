using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repository
{
    public class DataRepo
    {
        public DataRepo()
        {
            
        }

        public List<User> Users()
        {
            List<User> lstUser = new List<User>()
            {
                new User{Name = "Sourav", Email = "sourav@gmail.com"}
            };

            return lstUser;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
