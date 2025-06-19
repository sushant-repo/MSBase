using WebAPI.Data.Models;
using WebAPI.DTOs;

namespace WebAPI.Repositories
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<Patient> GetByIdAsync();
        Task AddAsync(Patient patient);
        Task DeleteAsync(int id);
        Task<List<PatientVisitDTO>> GetAllVisitsAsync(int patientId);
    }
}
