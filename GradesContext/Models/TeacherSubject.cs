using System;
using System.ComponentModel.DataAnnotations;

namespace GradesContext.Models
{
    public class TeacherSubject
    {
        //Attibutes

        [Key]
        public int IDTeacherSubject { get; set; }

        public int IDTeacher { get; set; }

        public int IDSubject { get; set; }

    }
}