using System.Collections.Generic;
using System.Linq;
using Gab.Data;
using Gab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gab.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDataContext _context;

        public CartController(AppDataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("cart")]
        public Cart Post([FromBody]Cart cart)
        {
            _context.Cart.Add(cart);
            _context.SaveChanges();
            return cart;
        }

        [HttpGet]
        [Route("cart")]
        public IList<Cart> Get()
        {
            return _context.Cart.ToList();
        }
    }
}