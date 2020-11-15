using QueueCheckIns.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QueueCheckIn.Services
{
    public interface IMailService
    {
        Task Send(EmailMessage mailRequest);
    }
}
