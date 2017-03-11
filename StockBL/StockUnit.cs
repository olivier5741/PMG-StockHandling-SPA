using DDD;

namespace StockBL
{
    public class StockUnit : IValueObject
    {
        public string Name { get; internal set; }
        
        //must be greater than 1 but equal to 1 if baseStockUnit
        public decimal FactorWithDefaulUnit { get; internal set; }
    }
}
