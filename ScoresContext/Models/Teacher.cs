using System;
using System.ComponentModel.DataAnnotations;

namespace ScoresContext.Models
{
    public class Teacher
    {
        [Key]
        public int IDTeacher { get; set; }

        public int IDTeacherType { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string FathersLastName { get; set; }

        public string MothersLastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string RFC { get; set; }

        public string CURP { get; set; }

        public int PayCheckNumber { get; set; }

        public string Password { get; set; }
    }
}