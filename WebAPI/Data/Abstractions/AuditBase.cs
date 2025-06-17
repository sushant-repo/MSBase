
namespace WebAPI.Data.Abstractions
{
    public class AuditBase : IAuditBase
    {
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public DateTime? ModifiedDateTime { get; set; } = default;
    }
}
