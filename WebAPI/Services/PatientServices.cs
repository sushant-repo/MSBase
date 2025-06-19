using WebAPI.Data.Models;
using WebAPI.DTOs;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class PatientServices(IPatientRepository patientRepository) : IPatientServices
    {
        private readonly IPatientRepository _patientRepository = patientRepository;

        public async Task<List<PatientDTO>> GetPatientsAsync()
        {
            var patients = await _patientRepository.GetAllAsync();
            return patients.Select(PatientToDTO).ToList();
        }

        private PatientDTO PatientToDTO(Patient x)
        {
            return new PatientDTO
            {
                PatientId = x.PatientId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender,
                DateOfBirth = x.DateOfBirth,
            };
        }
    }
}
