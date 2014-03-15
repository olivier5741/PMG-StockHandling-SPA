using DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockBL
{
    public class StockProduct : IAggregate
    {
        //PROPERTIES
        public string Id { get; internal set; }

        public Product Product { get; internal set; }

        public StockQuantity Quantity { get; internal set; }

        public StockQuantity MinimumStock { get; internal set; }

        public StockQuantity CriticalStock { get; internal set; }

        public IList<StockUnit> StockUnits { get; internal set; }

        //METHODS
        
        
    }
}
