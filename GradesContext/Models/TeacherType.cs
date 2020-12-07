using System;
using System.ComponentModel.DataAnnotations;

namespace GradesContext.Models
{
    public class TeacherType
    {
        [Key]
        public int IDTeacherType { get; set; }

        public string Name { get; set; }

        public int MinWorkingHours { get; set; }

        public int MaxWorkingHours { get; set; }
    }
}