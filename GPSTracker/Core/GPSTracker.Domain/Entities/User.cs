﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSTracker.Domain.Entities
{
    public class User:Base
    {
        public string Name { get; set; }
        public string ConnectionId { get; set; }

    }
}
