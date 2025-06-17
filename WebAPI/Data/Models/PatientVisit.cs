using WebAPI.Data.Abstractions;

namespace WebAPI.Data.Models
{
    public class PatientVisit : AuditBase
    {
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public decimal EDSSScore { get; set; }
        public required string DiseaseCourse { get; set; }
    }
}
