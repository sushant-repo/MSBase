using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Models;

namespace WebAPI.Data
{
    public class MSBaseDbContext : DbContext
    {
        private readonly string? _connectionString;

        public string ConnectionString => _connectionString;
        public MSBaseDbContext(DbContextOptions options, IConfiguration configuration)
            : base(options)
        {
            _connectionString = configuration.GetConnectionString("MSBaseConnectionString");
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientVisit> PatientVisits { get; set; }
    }
}
