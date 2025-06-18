using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Data.Models;
using WebAPI.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly MSBaseDbContext context;

        public PatientsController(MSBaseDbContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "GetPatients")]
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetPatients()
        {
            return await context
                .Patients
                .Select(x => PatientToDTO(x))
                .ToListAsync();
        }

        private static PatientDTO PatientToDTO(Patient x)
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
