using CORE.APP.Models;
using System;
using System.Collections.Generic;
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


        public string FullName{ get; set; }


        public string BirthDateF { get; set; } //  10/25/2025 13:30:45

        public string OverallGradeF { get; set; } //  95.50

        public string IsGraduatedF { get; set; } //  

    }
}
