using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Max200]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public int Age { get; set; }
    }
   
}