using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ModelValidation.Models
{
    public class Person2 : IValidatableObject
    {   
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public int? PersentAge { get; set; }

        public override string ToString()
        {
            return $"Age: {Age}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!DateOfBirth.HasValue && !Age.HasValue)
            {
                yield return new ValidationResult("Either of " +
                                            "Date of Birth or Age must be supplied", new[]
                {
                    nameof(Age)
                });
            }
        }
    }
}
