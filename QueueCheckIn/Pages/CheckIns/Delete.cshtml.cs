using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QueueCheckIns.Model;
using QueueCheckIn.Services;
using Microsoft.AspNetCore.Authorization;

namespace QueueCheckIn.Pages.CheckIns

{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly ICheckInRepository checkinReporitory;

        public DeleteModel(ICheckInRepository checkinReporitory)
        {
            this.checkinReporitory = checkinReporitory;
        }
        [BindProperty]
        public CheckIn CheckIn { get; set; }
        public IActionResult OnGet(int id)
        {
            CheckIn = checkinReporitory.GetCheckIn(id);
            if(CheckIn == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            CheckIn deletedCheckIn = checkinReporitory.Delete(CheckIn.Id);
            if (deletedCheckIn == null)
            {
                return RedirectToPage("/NoFound");
            }

            return RedirectToPage("Index");

        }
    }
}