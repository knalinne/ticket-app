using Microsoft.AspNetCore.Mvc.RazorPages;
using TicketApp.Models;
using TicketApp.Services;

namespace TicketApp.Pages.Tickets;

public class TicketsIndexModel: PageModel
{
    private readonly ITicketService _ticketService;

    public TicketsIndexModel(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    public List<Ticket> Tickets { get; set; }
    
    public void OnGet()
    {
        Tickets = _ticketService.GetAllTickets();
    }
}