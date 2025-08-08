using Microsoft.EntityFrameworkCore;
using CadastroPacientes.Models;

namespace CadastroPacientes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Patients> Patients { get; set; }
    }
}
