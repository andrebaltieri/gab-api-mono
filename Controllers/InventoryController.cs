using System;
using Gab.Data;
using Microsoft.AspNetCore.Mvc;

namespace Gab.Controllers
{
    public class InventoryController : Controller
    {
        private readonly AppDataContext _context;

        public InventoryController(AppDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("inventory/{id}/remove/{quantity}")]
        public IActionResult Get(Guid id, int quantity)
        {
            var product = _context.Products.Find(id);
            // Remove a quantidade informada do produto
            return Ok(new { message = "Baixa realizada com sucesso!" });
        }
    }
}