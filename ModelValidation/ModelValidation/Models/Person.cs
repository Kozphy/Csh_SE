using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class Person
    {
        [Required(ErrorMessage = "{0} can't be empty or null")]
        [Display(Name = "Person Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between" +
                                                            "{2} and {1} characters longs")]
        [RegularExpression("^[A-Za-z .]$", ErrorMessage = "{0} should contain only alphabets, " +
                                                          "space and dot (.)") ]
        public string? PersonName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "{0} should be a proper email address." )]
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.99, ErrorMessage =  "{0} should be between ${1} and ${2}")]
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
