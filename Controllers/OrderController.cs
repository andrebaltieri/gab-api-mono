using System.Collections.Generic;
using Gab.Data;
using Gab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gab.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDataContext _context;

        public OrderController(AppDataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("order")]
        public IActionResult Post([FromBody]IList<OrderItem> cart)
        {
            return Ok(new { message = "Pedido Realizado com sucesso!" });
        }
    }
}