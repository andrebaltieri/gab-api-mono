using System.Collections.Generic;
using System.Linq;
using Gab.Data;
using Gab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gab.Controllers
{
    public class SuggestionController : Controller
    {
        private readonly AppDataContext _context;

        public SuggestionController(AppDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("suggestions")]
        public IList<Product> Get()
        {
            return _context.Products.Take(3).ToList();
        }
    }
}