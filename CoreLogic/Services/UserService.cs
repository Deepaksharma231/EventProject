using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLogic.Models;

namespace CoreLogic.Services
{
    public class UserService
    {
        public List<User> GetAll()
        {
            var users=new List<User>()
            {
                new User() {Id=1,FirstName="Bhuvan",LastName="Koduri",Email="bhuvankoduri4800@gmail.com"},
                new User(){Id=1,FirstName="Bhargav",LastName="Chilukuri",Email="bhargxv@gamil.com"}
            };
            return users;
        }
    }
}
