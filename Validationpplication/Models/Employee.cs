using System.ComponentModel.DataAnnotations;

namespace Validationpplication.Models
{
    public class Employee
    {
      
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [StringLength(100,ErrorMessage ="Please Enter Valid Name ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please choose gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter date of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateofBirth { get; set; }

        [Required(ErrorMessage = "Choose batch time")]
        [Display(Name = "Batch Time")]
        [DataType(DataType.Time)]
        public DateTime? BatchTime { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [UserExist(ErrorMessage ="Email Id is already exists")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter website url")]
        [Display(Name = "Website Url")]
        [Url]
        public string WebSite { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
