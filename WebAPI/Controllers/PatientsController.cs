using Microsoft.AspNetCore.Mvc;
using WebAPI.DTOs;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController(IPatientServices patientServices) : ControllerBase
    {
        public IPatientServices _patientServices  = patientServices;

        [HttpGet(Name = "GetPatients")]
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetPatients()
        {
            return await _patientServices.GetPatientsAsync();
        }

        
    }
}
