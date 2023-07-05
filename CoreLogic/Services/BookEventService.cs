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


        private readonly MyContext _ctx;

		public BookEventService()
		{
			_ctx = new MyContext();
		}
		

		

		public List<BookEvent> GetAllEventDetails()
        {
			// MyContext _ctx = new MyContext();

			var bookevent =_ctx.BookEvents.ToList();
             return bookevent;
        }
        public void AddBookEvent(BookEvent bookEvent)
        {
           // MyContext _ctx = new MyContext();
            _ctx.BookEvents.Add(bookEvent);
            _ctx.SaveChanges();
        }

    }
}
