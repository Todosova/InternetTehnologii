using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Application3.Models.Hospital_Models
{
    public class Patient
    {
        public Patient()
        {
            Doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Името е задолжително")]
        public string Name { get; set; }
        public string Gender { get; set; }
        [Range(10000,99999, ErrorMessage = "Кодот мора да се содржи од точно 5 цифри")]
        [Display(Name ="Код на пациентот")]
        public string PatientCode { get; set; }
        public virtual List<Doctor> Doctors { get; set; }

    }
}