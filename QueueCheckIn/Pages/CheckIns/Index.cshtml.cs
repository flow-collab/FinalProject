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
    public class IndexModel : PageModel
    {
        private readonly ICheckInRepository checkInRepository;

        public IEnumerable<CheckIn> CheckIns { get; set; }

        public IndexModel(ICheckInRepository checkInRepository)
        {
            this.checkInRepository = checkInRepository;
        }

        public void OnGet()
        {
            CheckIns = checkInRepository.GetAllCheckIns();
            
        }
    }
}