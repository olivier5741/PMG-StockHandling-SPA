using DDD;

namespace StockBL
{
    public class Product : IValueObject
    {
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public StockUnit BaseUnit { get; internal set; }
    }
}
