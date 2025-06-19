using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Data.Models;

namespace WebAPI.Repositories
{
    public class PatientRepository(MSBaseDbContext context) : IPatientRepository
    {
        private readonly MSBaseDbContext _context = context;

        public Task AddAsync(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await _context.Patients.ToListAsync();
        }

        public Task<Patient> GetByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
