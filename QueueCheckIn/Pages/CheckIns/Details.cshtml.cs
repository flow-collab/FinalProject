using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QueueCheckIns.Model;
using QueueCheckIn.Services;

namespace QueueCheckIn.Pages.CheckIns
{
    public class DetailsModel : PageModel
    {
        private readonly ICheckInRepository checkinRepository;
        public DetailsModel(ICheckInRepository checkinRepository)
        {
            this.checkinRepository = checkinRepository;
        }

        public CheckIn CheckIn { get; private set; }

        public IActionResult OnGet(int id)
        {
            CheckIn = checkinRepository.GetCheckIn(id);

            if(CheckIn == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}