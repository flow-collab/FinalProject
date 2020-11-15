using Microsoft.AspNetCore.Mvc;
using QueueCheckIn.Services;
using QueueCheckIns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueCheckIn.ViewComponets
{
    public class WaitingTimeViewComponent : ViewComponent
    {
        private readonly ICheckInRepository checkInRepository;

        public WaitingTimeViewComponent(ICheckInRepository checkInRepository)
        {
            this.checkInRepository = checkInRepository;
        }

        public IViewComponentResult Invoke(Status? status = null)
        {
            var result = checkInRepository.TimeToWait(status);
            return View(result);
        }
    }
}
