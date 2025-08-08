using Microsoft.EntityFrameworkCore;
using PatientRegistration.Models;

namespace PatientRegistration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Patients> Patients { get; set; }
    }
}
