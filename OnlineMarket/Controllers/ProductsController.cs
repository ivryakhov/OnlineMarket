using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnlineMarket.Models;

namespace OnlineMarket.Controllers
{
    [Route("products")]
    public class ProductsController : ApiController
    {
        private IIdentityModel _context;

        public ProductsController()
        {
            _context = new IdentityModel();
        }

        public ProductsController(IIdentityModel context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            var a = _context.Products;
            return _context.Products.ToList();
        }
    }
}
