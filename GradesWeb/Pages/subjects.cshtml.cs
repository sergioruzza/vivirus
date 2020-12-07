using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.RazorPages;

using GradesContext;
using GradesContext.Models;

namespace GradesWeb.Pages
{
    public class SubjectsModel : PageModel
    {
        public IEnumerable<Subject> Subjects { get; set; }
        private Grades database;

        public SubjectsModel(Grades injectedDatabase)
        {
            database = injectedDatabase;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Subjects Page";
            Subjects = database.Subject;
        }
    } 
}