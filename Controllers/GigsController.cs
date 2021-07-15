using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}