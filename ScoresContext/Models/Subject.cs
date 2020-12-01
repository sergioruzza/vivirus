using System;
using System.ComponentModel.DataAnnotations;

namespace ScoresContext.Models
{
    public class Subject
    {
        //Attibutes

        [Key]
        public int IDSubject { get; set; }

        public string Name { get; set; }

        public int TheoricalHours { get; set; }

        public int PracticalHours { get; set; }


    }
}