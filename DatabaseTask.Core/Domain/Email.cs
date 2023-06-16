using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Email
    {
        [Key]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string? Comment { get; set; }

     
    }
}
