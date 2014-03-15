using CoreDomain;
using DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL
{
    public class Product : IValueObject
    {
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public Unit BaseUnit { get; internal set; }
    }
}
