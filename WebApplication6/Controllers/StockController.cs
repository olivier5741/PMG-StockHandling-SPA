using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class StockController : ApiController
    {
        List<StockProduct> products = new List<StockProduct>(){
            new StockProduct(){
                Id = "StockProduct/1",
                Product = new Product(){Name = "Oranges"},
                AvailableQuantity = new ProductQuantity(){Amount=10, Unit=ProductQuantityUnit.SingleUnit}
            }
        };

        // GET api/stock
        public IEnumerable<StockProduct> Get()
        {
            return products;
        }

        // GET api/stock/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/stock
        public void Post([FromBody]string value)
        {
        }

        // PUT api/stock/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/stock/5
        public void Delete(int id)
        {
        }
    }

    public class StockProduct
    {
        public string Id { get; set; }
        public Product Product { get; set; }
        public ProductQuantity AvailableQuantity {get; set;}
    }

    public class Product
    {
        public string Name {get; set;}
    }

    public enum ProductQuantityUnit {Box, SingleUnit};

    public class ProductQuantity
    {
        public int Amount { get; set; }
        public ProductQuantityUnit Unit { get; set; }
    }
}
