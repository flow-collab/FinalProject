using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QueueCheckIn.Services;
using QueueCheckIns.Model;

namespace QueueCheckIn.Pages.Employee
{
    public class ListPast30DayModel : PageModel
    {
        private readonly ICheckInRepository checkInRepository;

        public IEnumerable<CheckIn> CheckIns { get; set; }

        public ListPast30DayModel(ICheckInRepository checkInRepository)
        {
            this.checkInRepository = checkInRepository;
        }

        public void OnGet()
        {
            CheckIns = checkInRepository.GetAllCheckInsPast30Days();
        }
    }
}

