using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace week5.Models
{
    public class EmployeeViewModel
    {        
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public float Phone { get; set; }

        [Required]
        public int StateId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        public bool Marital_Status { get; set; }

        public List<State> StateList { get; set; }
        public List<City> CityList { get; set; }
    }
}