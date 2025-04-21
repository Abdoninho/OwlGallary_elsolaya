using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owl_Gallery.Models
{
    public class Customer
    {
        [DefaultValue(0)]
        public int ID { get; set; }


        [Required(ErrorMessage = "email is required")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string email { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
