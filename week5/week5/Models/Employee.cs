using System.ComponentModel.DataAnnotations;

namespace week5.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        
        public string EmployeeName { get; set; }
        
        public string Email { get; set; }
        
        public float Phone { get; set; }

       
        public int StateId { get; set; }

        public int CityId { get; set; }
      
        public bool Marital_Status { get; set; }
    }
}