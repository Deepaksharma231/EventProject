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
            var users = new List<User>()
            {
                 new User() { Id=1 , FirstName = "Sahib" , LastName="Kumar",Email="saheb123@gmail.com"},
                 new User() { Id=2 , FirstName = "deepak" , LastName="Kumar",Email="deepak123@gmail.com"},
				 new User() { Id=3 , FirstName = "bhuvan" , LastName="Kumar",Email="bhuvan123@gmail.com"}
			};
            return users;
        }
    }
}
