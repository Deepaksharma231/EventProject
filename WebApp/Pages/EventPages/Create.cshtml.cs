using CoreLogic.Model;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Event
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public BookEvent BookEvent { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || BookEvent== null)
            {
				BookEventService bookEventService = new BookEventService();
				bookEventService.AddBookEvent(BookEvent);
			}
            
            return RedirectToPage("/Event");
        }

        private IActionResult Pages(ModelStateDictionary modelState)
        {
            throw new NotImplementedException();
        }
    }
}
