using DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBL
{
    public class StockUnit : IValueObject
    {
        public string Unit { get; internal set; }
    }
}
