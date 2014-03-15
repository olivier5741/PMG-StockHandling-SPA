﻿using DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBL
{
    public class Product : IValueObject
    {
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public StockUnit BaseUnit { get; internal set; }
    }
}