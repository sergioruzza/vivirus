using System;
using System.ComponentModel.DataAnnotations;

namespace ScoresContext.Models
{
    public class TeacherType
    {
        //Attibutes

        [Key]
        public int IDTeacherType { get; set; }

        public string Name { get; set; }

        public int MinWorkingHours { get; set; }

        public int MaxWorkingHours { get; set; }
    }
}