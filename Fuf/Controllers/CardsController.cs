using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuf.Controllers
{
    public class CardsController : Controller
    {
        [Route("cards/{id}")]
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
