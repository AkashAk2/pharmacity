using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FIT5032_Pharmacity.Models
{
    public class Patient
    {
        
        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Password")]
        public string Pword { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Pword")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Residential Address")]
        public string HomeAddress { get; set; }

        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }

        [Display(Name = "Email")]
        public string EmailId { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }
    }
}
