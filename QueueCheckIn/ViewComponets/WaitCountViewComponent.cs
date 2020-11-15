using Microsoft.AspNetCore.Mvc;
using QueueCheckIn.Services;
using QueueCheckIns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueCheckIn.ViewComponets
{
    public class WaitCountViewComponent : ViewComponent
    {
        private readonly ICheckInRepository checkInRepository;

        public WaitCountViewComponent(ICheckInRepository checkInRepository )
        {
            this.checkInRepository = checkInRepository;
        }

        public IViewComponentResult Invoke(Status? status = null)
        {
            var result = checkInRepository.CountWaiting(status);
            return View(result);
        }
    }
}
