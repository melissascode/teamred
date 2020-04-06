using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace teamred.Pages
{
    public class StudyModel : PageModel
    {
        public string Sp { get; set; }
        public string Title { get; set; }
        private readonly ILogger<StudyModel> _logger;

        public StudyModel(ILogger<StudyModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet(string sp)
        {
            Sp = sp;
            Title = "Study Plan Name"; // Must be retrieved from database
            // Need to also check if user has access to Sp
            if(Sp == null) {
                return new RedirectToPageResult("Index");
            }
            return Page();
        }
    }
}
