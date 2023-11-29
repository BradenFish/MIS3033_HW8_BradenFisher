using Microsoft.EntityFrameworkCore;
using MIS3033_HW8_BradenFisher.Models;

namespace MIS3033_HW8_BradenFisher.Data
{
    public class PatientDB : DbContext// Change DbCon to your own database connect class name
    {
        public DbSet<Patient> Patients { get; set; }// Define a table in the database. The table name here is: Students
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=129.15.67.240;Database=fish0090hw8db;Port=5432;Username=fish0090;Password=jFo9OvfVJ5QFHHspd1Au");
        }
    }

}
