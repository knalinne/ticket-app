using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TicketApp.Pages;

public class IndexModel : PageModel
{
    public ActionResult OnGet(int id)
    {
        this.Id = id;
        if (id > 100)
            return NotFound();
        
        return Page();
    }

    public int Id { get; set; }
}
