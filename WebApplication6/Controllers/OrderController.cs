using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class OrderController : RavenDbController
    {
        public IEnumerable<OrderProductDto> Get(string id)
        {
            return new List<OrderProductDto> { 
                new OrderProductDto{
                        Product = "Citron",
                        Quantity = 10,
                        Unit = "1",
                        Price = 32.45m
                    },
                new OrderProductDto{
                        Product = "Orange",
                        Quantity = 24,
                        Unit = "2",
                        Price = 78.32m
                    }
            };
        }

        public async Task<HttpResponseMessage> Post([FromBody]Object stockProduct)
        {
            var product = new OrderProductDto
            {
                Product = "Citron",
                Quantity = 10,
                Unit = "1",
                Price = 32.45m
            };

            await Session.StoreAsync(product);

            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }

    public class OrderProductDto
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
    }
}
