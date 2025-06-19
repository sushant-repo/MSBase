using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.DTOs;

namespace WebAPI.Services
{
    public interface IPatientServices
    {
        Task<List<PatientDTO>> GetPatientsAsync();
        Task<List<PatientVisitDTO>> GetPatientVisitsAsync(int patientId);
    }
}
