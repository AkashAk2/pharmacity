using System.ComponentModel.DataAnnotations;

namespace FIT5032_Pharmacity.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }

        [Display(Name ="Enter your full name")]
        public string PatientName { get; set; }
        

        [Display(Name ="Email ID")]
        public string EmailId  { get; set; }

        [Display(Name = "Vaccine Name")]
        public String VaccineName { get; set; }

        [Display(Name ="Select Time")]
        public DateTime AppointmentTime { get; set; }
    }
}
