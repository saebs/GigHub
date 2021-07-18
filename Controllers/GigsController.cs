using System.Linq;
using GigHub.Data;
using GigHub.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            var viewGigFormModel = new GigFormViewModel()
            {
                Genres = _context.Genres.ToList()
            }; 
            return View(viewGigFormModel);
        }
    }
}