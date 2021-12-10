using System.ComponentModel.DataAnnotations;

namespace MvcExample.Models
{
    public class SuperHeroCreateModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(18, 200, ErrorMessage = "The hero must be adult and he cannot be too old")]
        public int Age { get; set; }

        [Required, RegularExpression("[a-zA-Z]*(,[a-zA-Z]+)*", ErrorMessage = "The list of powers need to be comma separated strings")]
        public string Powers { get; set; }
    }
}