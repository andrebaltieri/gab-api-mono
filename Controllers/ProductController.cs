using System.Collections.Generic;
using System.Linq;
using Gab.Data;
using Gab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gab.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDataContext _context;

        public ProductController(AppDataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("products")]
        public Product Post([FromBody]Product product)
        {



            // Teste
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        [HttpGet]
        [Route("products")]
        public IList<Product> Get()
        {
            return _context.Products.ToList();
        }
    }
}