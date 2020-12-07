using System;
using System.ComponentModel.DataAnnotations;

namespace GradesContext.Models
{
    public class Assignature
    {
        //Attibutes

        [Key]
        public int IDAssignature { get; set; }

        public int IDTeacher { get; set; }

        public int IDSubject { get; set; }

        public int IDGroup { get; set; }


    }
}