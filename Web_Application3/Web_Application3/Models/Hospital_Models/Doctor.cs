using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Application3.Models.Hospital_Models
{
    public class Doctor
    {

        public Doctor()
        {
         Patients =new List<Patient>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}