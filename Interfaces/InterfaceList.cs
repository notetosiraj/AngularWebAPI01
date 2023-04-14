namespace CRM01.Interfaces
{
    public interface IAuditModel
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        long CreatedBy { get; set; }
        long ModifiedBy { get; set; }
    }
}
