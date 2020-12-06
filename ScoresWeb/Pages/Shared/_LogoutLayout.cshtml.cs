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
    public class _LogoutLayoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "teacher", null);
            return RedirectToPage("/index");  
        }       
    }   
}