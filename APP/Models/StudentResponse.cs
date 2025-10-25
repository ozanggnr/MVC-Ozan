using CORE.APP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Models
{
    public class StudentResponse : Response
    {
     
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirtDate { get; set; }

        public decimal? OverallGrade { get; set; }

        public bool IsGraduated { get; set; }

        [DisplayName("Full Name")]
        public string FullName{ get; set; }

        [DisplayName("Birth Date")]
        public string BirthDateF { get; set; } //  10/25/2025 13:30:45

        [DisplayName("Overal Grade")]
        public string OverallGradeF { get; set; } //  95.50

        [DisplayName("Status")]
        public string IsGraduatedF { get; set; } 

    }
}
