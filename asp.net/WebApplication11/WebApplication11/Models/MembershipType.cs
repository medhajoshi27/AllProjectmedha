using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models
{
    public class MembershipType
    {
        public string Name { get; set; }

        [Key]
        public string email { get; set; }
    }
}