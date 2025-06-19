using WebAPI.Data;
using WebAPI.DTOs;

namespace WebAPI.Services
{
    public interface IPatientServices
    {
        Task<List<PatientDTO>> GetPatientsAsync();
    }
}
