using DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBL
{
    public class StockQuantity : IValueObject
    {
        public decimal Quantity { get; internal set; }

        public StockUnit Unit { get; internal set; }
    }
}
