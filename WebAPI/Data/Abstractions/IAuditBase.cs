namespace WebAPI.Data.Abstractions
{
    public interface IAuditBase
    {
        DateTime CreatedDateTime {  get; set; }
        DateTime? ModifiedDateTime { get; set; }
    }
}
