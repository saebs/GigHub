using System.Linq;
using GigHub.Data;
using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        
        // [Authorize]
        public IActionResult Create()
        {
            var viewGigFormModel = new GigFormViewModel()
            {
                Genres = _context.Genres.ToList()
            }; 
            return View(viewGigFormModel);
        }

        [HttpPost]
        public IActionResult Create(GigFormViewModel viewModel)
        {
            // TODO
            // var gig = new Gig
            // {
            //
            // }

            return View();

        }
    }
}