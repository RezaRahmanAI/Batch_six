using Batch_six.Domain;
using Microsoft.EntityFrameworkCore;

namespace Batch_six.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> option): DbContext(option)
    {
       public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Prescription> prescriptions { get; set; }
        public DbSet<Billing> Billings { get; set; }


    }
}
