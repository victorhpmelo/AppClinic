using AppClinic.Models;
using Microsoft.EntityFrameworkCore;

namespace AppClinic.Data
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext>options) : base(options) 
        { }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
