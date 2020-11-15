using QueueCheckIns.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueCheckIn.Services
{
    public interface IRegister
    {
        Register Add(Register newRegister);
    }
}
