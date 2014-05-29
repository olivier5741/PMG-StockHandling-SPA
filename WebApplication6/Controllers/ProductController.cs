using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<ProductDto> Get()
        {
            return new List<ProductDto>{
                new ProductDto{
                    Id = "1",
                    OrderId = "4544534",
                    Name = "Morphine Liquid",
                    Units = new List<UnitDto>{
                        new UnitDto{
                            Id = "1",
                            Name = "Seringue",
                            State = UnitState.InUse,
                            IsBaseUnit = true,
                            UnitUses = new List<UnitUse>{
                                UnitUse.Stock
                            }
                        },
                        new UnitDto{
                            Id = "2",
                            Name = "Boîte",
                            State = UnitState.InUse,
                            IsBaseUnit = false,
                            UnitUses = new List<UnitUse>{
                                UnitUse.Order,
                                UnitUse.Stock
                            }
                        }
                    }
                }
            };
        }
    }

    public class ProductDto
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string Name { get; set; }
        public IEnumerable<UnitDto> Units { get; set; }
    }

    public class UnitDto
    {
        public UnitDto()
        {
            IsBaseUnit = false;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public UnitState State { get; set; }
        public IEnumerable<UnitUse> UnitUses { get; set; }
        public bool IsBaseUnit { get; set; }
        public int BaseUnitMultiple { get; set; }
    }

    public enum UnitState { InUse, Deprecated, Removed}
    public enum UnitUse { Order, Stock}
}
