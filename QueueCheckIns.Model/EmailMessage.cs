﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QueueCheckIns.Model
{
    public class EmailMessage
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
