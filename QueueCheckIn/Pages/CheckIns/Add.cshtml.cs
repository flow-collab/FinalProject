using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QueueCheckIns.Model;
using QueueCheckIn.Services;
using Microsoft.AspNetCore.Http;

namespace QueueCheckIn.Pages.CheckIns
{
    public class AddModel : PageModel
    {
        private readonly ICheckInRepository checkinRepository;

        public AddModel(ICheckInRepository checkinRepository)
        {
            this.checkinRepository = checkinRepository;
        }

        [BindProperty]
        public CheckIn CheckIn { get; set; }

        public IActionResult OnGet()
        {
            CheckIn = new CheckIn();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (CheckIn.Id > 0)
                {
                    CheckIn = checkinRepository.Update(CheckIn);
                }
                else
                {
                    CheckIn = checkinRepository.Add(CheckIn);
                }
                return RedirectToPage("AddConfirmed");

            }
            return Page();
        }
    }
}
