using Microsoft.EntityFrameworkCore;
using WebPage.Models;

namespace WebPage.Data
{
    // Clase que representa el contexto de la base de datos
    public class ApplicationDbContext : DbContext
    {
        // Constructor que recibe las opciones de configuración para el contexto
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet que representa la tabla ContactForms en la base de datos
        public DbSet<ContactForm> ContactForms { get; set; }
    }
}
