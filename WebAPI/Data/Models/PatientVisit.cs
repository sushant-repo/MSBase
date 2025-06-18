using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPI.Data.Abstractions;

namespace WebAPI.Data.Models
{
    public class PatientVisit : AuditBase
    {
        [Key]
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public decimal EDSSScore { get; set; }
        public required string DiseaseCourse { get; set; }
    }
}
