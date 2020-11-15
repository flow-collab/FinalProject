using System;
using System.Collections.Generic;
using System.Text;

namespace QueueCheckIns.Model
{
    public class QueueTime
    {
        public Status Status { get; set; }
        public Category Category { get; set; }

        //public CheckIn CheckIn { get; set; }
        
        public int TotalWait { get; set; }

        public int Count { get; set; }
    }
}
