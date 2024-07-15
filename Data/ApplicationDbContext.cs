using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FIT5032_Pharmacity.Models;

namespace FIT5032_Pharmacity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FIT5032_Pharmacity.Models.Appointment> Appointment { get; set; }
        public DbSet<FIT5032_Pharmacity.Models.Patient> Patient { get; set; }
        public DbSet<FIT5032_Pharmacity.Models.Pharmacist> Pharmacist { get; set; }
        public DbSet<FIT5032_Pharmacity.Models.Vaccine> Vaccine { get; set; }
        
        
    }
}