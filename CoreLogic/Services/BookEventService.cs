using CoreLogic.Data;
using CoreLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services
{
    public class BookEventService
    {
       

        public List<BookEvent> GetAllEventDetails()
        {
           MyContext ctx = new MyContext();

            var bookevent=ctx.BookEvents.ToList();
            return bookevent;
        }

    }
}
