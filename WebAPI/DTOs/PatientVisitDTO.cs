namespace WebAPI.DTOs
{
    public class PatientVisitDTO : PatientDTO
    {
        public int VisitId { get; set; }
        public DateOnly VisitDate { get; set; }
        public decimal EDSSScore { get; set; }
        public required string DiseaseCourse { get; set; }
    }
}
