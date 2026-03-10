namespace TicketApp.Models;

public record Ticket(int Id, string Title, string Status, DateTime CreatedAt, DateTime UpdatedAt);