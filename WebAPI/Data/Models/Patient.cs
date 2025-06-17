using WebAPI.Data.Abstractions;

namespace WebAPI.Data.Models
{
    public class Patient : AuditBase
    {
        public int PatientId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
