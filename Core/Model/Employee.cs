using CRM01.Interfaces;

namespace CRM01.Core.Model
{
    public class Employee : AuditModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayId { get; set; }
        public string? Union { get; set; }
        public int? DesignationId { get; set; }
        public int? RoleId { get; set; }
        public int? SupervisorId { get; set; }
        public string? Skills { get; set; }
        public DateTime? JoinDate { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

    }
}
