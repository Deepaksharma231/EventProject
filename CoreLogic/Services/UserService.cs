using CoreLogic.Data;
using CoreLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services
{
   public class UserService
    {
        public List<User> GetAll()
        {

            MyContext ctx = new MyContext();

            var users = ctx.Users.ToList();
        
            return users;
        }
    }
}
