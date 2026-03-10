using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TicketApp.Models;
using TicketApp.Services;

namespace TicketApp.Pages.Tickets;

public class DetailsModel : PageModel
{
    private readonly ITicketService _ticketService;

    public DetailsModel(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    public Ticket? Ticket { get; set; }

    public ActionResult OnGet(int ticketId)
    {
        Ticket = _ticketService.GetTicketById(ticketId);
        if (Ticket == null)
        {
            return NotFound();
        }

        return Page();
    }
}