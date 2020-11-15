using Microsoft.AspNetCore.Authorization;
using QueueCheckIns.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QueueCheckIn.Services
{
    public interface ICheckInRepository
    {
        IEnumerable <CheckIn> GetAllCheckIns();
        IEnumerable<CheckIn> GetAllCheckInsPast30Days();
        IEnumerable<CheckIn> GetAllCheckInsPast14Days();
        CheckIn GetCheckIn(int id);
        CheckIn Update(CheckIn updatedCheckIn);
        CheckIn Add(CheckIn newCheckIn);
        CheckIn Delete(int id);
        IEnumerable <QueueCount> CountWaiting(Status? status);

        IEnumerable<QueueTime> TimeToWait(Status? status);
        //int WaitLength();

        //int CategoryTotal();

        //int WaitTime();
    }
}
