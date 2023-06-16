using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class SalesOrder
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Start  { get; set; }
        public DateTime End { get; set; }
        public int Amount { get; set; }
        public string Frequency { get; set; }
        public bool AautomaticRenew { get; set; }
        public string? Comment { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public Email Email { get; set; }
        public Guid EmailId { get; set; }
        ///Võõrvõtmeid juurde panna
    }
}
