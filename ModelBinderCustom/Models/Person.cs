using System.ComponentModel.DataAnnotations;

namespace ModelBinderCustom.Models
{
    public class Person
    {
        public string PersonName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Phone format error")]
        public int Phone { get; set; }
    }
}
