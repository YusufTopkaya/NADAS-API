﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.Entities.Concrete
{
    public class Notification
    {
        public string body { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string color { get; set; }
    }
}
