using System.ComponentModel.DataAnnotations;

namespace FIT5032_Pharmacity.Models
{
    public class Vaccine
    {
        public Guid Id  { get; set; }

        [Display(Name ="Vaccine Name")]
        public string VName { get; set; }

    }
}
