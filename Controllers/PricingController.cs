using System;
using Gab.Data;
using Microsoft.AspNetCore.Mvc;

namespace Gab.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDataContext _context;

        public PricingController(AppDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("products/{id}/price")]
        public IActionResult Get(Guid id)
        {
            var product = _context.Products.Find(id);
            return Ok(new { price = product.Price });
        }
    }
}