using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TicketApp.Models;

namespace TicketApp.Pages.Tickets;

public class Details : PageModel
{
    public Ticket? Ticket { get; set; }

    private readonly List<Ticket> _tickets = new()
    {
        new(1, "Mettre en place l'authentification JWT", "Done", new DateTime(2026, 1, 5), new DateTime(2026, 1, 12)),
        new(2, "Créer le module de gestion des utilisateurs", "In Progress", new DateTime(2026, 1, 8), new DateTime(2026, 3, 1)),
        new(3, "Corriger le bug d'affichage sur mobile", "Open", new DateTime(2026, 2, 14), new DateTime(2026, 2, 14)),
        new(4, "Optimiser les requêtes SQL lentes", "In Progress", new DateTime(2026, 2, 20), new DateTime(2026, 3, 5)),
        new(5, "Rédiger la documentation de l'API REST", "Open", new DateTime(2026, 3, 1), new DateTime(2026, 3, 1)),
        new(6, "Implémenter le système de notifications", "Done", new DateTime(2026, 1, 15), new DateTime(2026, 2, 3)),
        new(7, "Migrer la base de données vers PostgreSQL", "Blocked", new DateTime(2026, 2, 10), new DateTime(2026, 3, 8)),
        new(8, "Ajouter les tests unitaires sur le service de paiement", "Open", new DateTime(2026, 3, 7), new DateTime(2026, 3, 7)),
        new(9, "Refactoriser le pipeline CI/CD GitLab", "Done", new DateTime(2026, 1, 22), new DateTime(2026, 2, 5)),
        new(10, "Mettre à jour les dépendances NuGet obsolètes", "In Progress", new DateTime(2026, 3, 9), new DateTime(2026, 3, 10)),
    };

    public IActionResult OnGet(int id)
    {
        Ticket = _tickets.FirstOrDefault(t => t.Id == id);

        if (Ticket == null)
            return NotFound();

        return Page();
    }
}