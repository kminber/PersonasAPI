﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasApi.Models
{
    public class Hero
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsBad { get; set; }
    }
}
