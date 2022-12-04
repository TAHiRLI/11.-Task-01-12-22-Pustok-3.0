using Microsoft.AspNetCore.Mvc;
using Pustok.DAL;
using Pustok.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pustok.Areas.manage.Controllers
{
    [Area("Admin")]
    public class AuthorController : Controller
    {
        private readonly PustokDbContext _context;

        public AuthorController(PustokDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Author> authorList = _context.Authors.ToList();
            return View(authorList);
        }
    }
}
