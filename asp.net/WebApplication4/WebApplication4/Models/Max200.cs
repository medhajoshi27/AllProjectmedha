using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Max200 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var t = Convert.ToString(value).Length;
                if (t < 20)
                {
                    return ValidationResult.Success;

                }
                else
                {
                    return new ValidationResult("Name should be less than 20 characters");
                }
            }
            else
            {
                return new ValidationResult("Please Enter Name");

            }

        }
    }
}