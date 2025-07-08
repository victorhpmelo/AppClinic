using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppClinic.Models
{
    [Display(Name ="Patient")]
     public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        public string PatientName { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate{ get; set; }

        public decimal Paycheck { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
