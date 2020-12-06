using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ScoresContext;
using ScoresContext.Models;
using System.ComponentModel.DataAnnotations;
using ScoresWeb.Helpers;


namespace ScoresWeb.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Account { get; set; }

        [BindProperty]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool Error { get; set; }

        private Scores database;

        public IndexModel(Scores injectedDatabase)
        {
            database = injectedDatabase;
        }

        public IActionResult OnGet()
        {
            ViewData["Title"] = "Login";
            Teacher teacher = SessionHelper.GetObjectFromJson<Teacher>(HttpContext.Session, "teacher");

            if (teacher != null)
            {
                return RedirectToPage("/menu");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                int checkNumber = 0;
                if (int.TryParse(Account, out checkNumber))
                {
                    IEnumerable<Teacher> teachers = database.Teacher;
                    foreach (var teacher in teachers)
                    {
                        if (teacher.PayCheckNumber == checkNumber && teacher.Password == Password)
                        {
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "teacher", teacher);
                            return RedirectToPage("/menu"); 
                        }
                    }
                }
            }
            Error = true;
            return RedirectToPage("/index", new { Error } );
        }
    } 
}