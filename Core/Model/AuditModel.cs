using CRM01.Interfaces;

namespace CRM01.Core.Model
{
    public class AuditModel : IAuditModel
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
    }
}
