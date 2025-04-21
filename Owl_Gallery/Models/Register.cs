using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Owl_Gallery.Models
{
    public class Register
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto increment
        public int Id { get; set; }


        [Required(ErrorMessage = "firstname is required")] //attribute tend to make the value of any field not null 
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = " Passwords are not matched")]
        public string ConfirmPassword { get; set; }
    }
}
