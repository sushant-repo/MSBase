using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebAPI.Data;
using WebAPI.Data.Models;
using WebAPI.DTOs;

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

        public async Task<List<PatientVisitDTO>> GetAllVisitsAsync(int patientId)
        {
            using (var connection = new SqlConnection(_context.ConnectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                return (await connection.QueryAsync<PatientVisitDTO>(
                    "dbo.spsSelectPatientVisit",
                    new { patientId },
                    commandType: CommandType.StoredProcedure
                    )).ToList();
            }
        }

        public Task<Patient> GetByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
