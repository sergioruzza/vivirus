using System;
using System.ComponentModel.DataAnnotations;

namespace GradesContext.Models
{
    public class Group
    {
        //Attibutes

        [Key]
        public int IDGroup { get; set; }

        public int IDPeriodType { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime CloseDate { get; set; }


    }
}