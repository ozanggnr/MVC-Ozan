using CORE.APP.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Domain
{
    public class Student:Entity
    {

        [Required,StringLength(50)]
        public string Name{ get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        public DateTime BirtDate { get; set; }

        public decimal? OverallGrade { get; set; }

        public bool IsGraduated { get; set; }
    }
}
