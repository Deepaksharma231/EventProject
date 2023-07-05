using CoreLogic.Data;
using CoreLogic.Model;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class EventModel : PageModel
    {
		BookEventService service;
		public List<BookEvent> bookEvents { get; set; }
		public void OnGet()
        {
			service = new BookEventService();
			bookEvents = service.GetAllEventDetails();
		}
    }
}
