using System.ComponentModel.DataAnnotations;
using WebAPI.Data.Abstractions;

namespace WebAPI.Data.Models
{
    public class Patient : AuditBase
    {
        [Key]
        public int PatientId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
