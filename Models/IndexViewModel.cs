﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAuthenticationAuthorization.Models
{
    public class IndexViewModel
    {
        public IEnumerable<SuperMarket> SuperMarkets { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
