using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TicketApp.Models;
using TicketApp.Services;

namespace TicketApp.Pages.Tickets;

public class CreateTicket : PageModel
{
    private readonly ITicketService _ticketService;

    public CreateTicket(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [BindProperty]
    public Ticket Ticket { get; set; }

    public ActionResult OnPost()
    {
        var newId = _ticketService.GetNextId();
        var newTicket = Ticket with { Id = newId, CreatedAt = DateTime.Now , UpdatedAt = DateTime.Now };
        _ticketService.CreateTicket(newTicket);
        
        return RedirectToPage("/Tickets/Index");
    }
}