﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> TrickList { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
    }
}
