using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTOs
{
    public class PatientDTO
    {
        public int PatientId { get; set; }

        [Required]
        [MaxLength(100)]
        public required string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public required string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [RegularExpression("Male|Female|Other", ErrorMessage = "Gender must be Male, Female, or Other")]
        public required string Gender { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
