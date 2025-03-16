using Microsoft.EntityFrameworkCore;
using WebPage.Models; // Asegúrate de que este namespace coincida con el de tus modelos

namespace WebPage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Agregar DbSet para los modelos
        public DbSet<ContactForm> ContactForms { get; set; } // ContactForm debe ser tu modelo

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
