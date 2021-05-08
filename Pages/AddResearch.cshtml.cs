using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_RazorPages.Models;

namespace NET_RazorPages.Pages
{
    public class AddResearchModel : PageModel
    {
        [BindProperty]
        public ResearchModel Research { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("./Research");
        }
    }
}
