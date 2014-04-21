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
                Id = "1",
                Product = new Product(){Name = "Orange"},
                AvailableBaseQuantity = new ProductQuantity(){
                    Amount=10, 
                    Unit=ProductQuantityUnit.SingleUnit
                }
            },
            new StockProduct(){
                Id = "2",
                Product = new Product(){Name = "Citron"},
                AvailableQuantity = new ProductQuantity(){
                    Amount=4, 
                    Unit=ProductQuantityUnit.Box
                },
                AvailableBaseQuantity = new ProductQuantity(){
                    Amount=40,
                    Unit=ProductQuantityUnit.SingleUnit
                }
            }
        };

        // GET api/stock
        public IEnumerable<StockProduct> Get()
        {
            return products;
        }

        // GET api/stock/5
        public StockProduct Get(string id)
        {
            return products.Where(p => p.Id == id).FirstOrDefault();
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
        public ProductQuantity AvailableBaseQuantity {get; set;}
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
