using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.RazorPages;

using ScoresContext;
using ScoresContext.Models;

namespace ScoresWeb.Pages
{
    public class SubjectsModel : PageModel
    {
        public IEnumerable<Subject> Subjects { get; set; }
        private Scores database;

        public SubjectsModel(Scores injectedDatabase)
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