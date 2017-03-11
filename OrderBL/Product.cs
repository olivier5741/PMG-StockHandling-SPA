using CoreDomain;
using DDD;

namespace OrderBL
{
    public class Product : IValueObject
    {
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public Unit BaseUnit { get; internal set; }
    }
}
