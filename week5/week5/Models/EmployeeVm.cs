using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace week5.Models
{
    public class EmployeeVm
    {
        public int Id { get; set; }
        [Required]
        public Employee employee { get; set; }
        [Required]
        public List<State> stat { get; set; }
        [Required]
        public List<City> cit { get; set; }
    }
}