using System;
using System.ComponentModel.DataAnnotations;

namespace GradesContext.Models
{
    public class PeriodType
    {
        //Attibutes

        [Key]
        public int IDPeriodType { get; set; }

        public string Name { get; set; }

        public int Months { get; set; }
    }
}