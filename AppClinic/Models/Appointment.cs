using System.ComponentModel.DataAnnotations;

namespace AppClinic.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public int PatientId { get; set; }

        public Patient Patient { get; set; } 
        [Required]
        public string Doctor { get; set;}

        public string Specialty { get; set;}

        [Required]
        public DateTime AppointmentDateTime { get; set; }

        public string AppointmentType { get; set; }

    }
}
