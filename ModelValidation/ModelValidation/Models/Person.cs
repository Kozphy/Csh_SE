using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class Person
    {
        [Required(ErrorMessage = "{0} can't be empty or null")]
        public string? PersonName { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public double? Price { get; set; }

        public override string ToString()
        {
            return @$"Person object - Person name: {PersonName},
                      Email: {Email},
                      Phone: {Phone},
                      Password: {Password},
                      ComfirmPassword: {ConfirmPassword},
                      Price: {Price}";
        }
    }
}
