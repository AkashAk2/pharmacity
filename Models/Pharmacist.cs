using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FIT5032_Pharmacity.Models
{
    public class Pharmacist
    {
        
        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email ID")]
        public string EmailId { get; set; }

        public string Password { get; set; }

        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }
    }
}
