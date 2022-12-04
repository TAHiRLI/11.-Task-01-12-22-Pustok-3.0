using Microsoft.AspNetCore.Mvc;
using Pustok.DAL;
using Pustok.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pustok.Areas.manage.Controllers
{
    [Area("Admin")]
    public class GenreController : Controller
    {

        private readonly PustokDbContext _context;

        public GenreController(PustokDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Genre> genreList = _context.Genres.ToList();
            return View(genreList);
        }
    }
}
