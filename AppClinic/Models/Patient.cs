using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppClinic.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        public string PatientName { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime BirthDate{ get; set; }

        public decimal Paycheck { get; set; }


    }
}
