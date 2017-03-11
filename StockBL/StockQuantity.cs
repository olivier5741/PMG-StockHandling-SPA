using DDD;

namespace StockBL
{
    public class StockQuantity : IValueObject
    {
        public decimal Quantity { get; internal set; }

        public StockUnit Unit { get; internal set; }
    }
}
