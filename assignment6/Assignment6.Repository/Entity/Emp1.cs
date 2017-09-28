using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6.Repository.Entity
{
    public class Emp1
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public long Phone { get; set; }
        [Required]
        public bool MaritalStatus { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
    }
}
