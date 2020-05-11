using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CaptialsGame.Web.Models;
using CapitalsGame.Model;
using CapitalsGame.Services.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CaptialsGame.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICapitalsGameRepository _capitalsGameRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICapitalsGameRepository capitalsGameRepository)
        {
            _logger = logger;

            _capitalsGameRepository = capitalsGameRepository ??
                throw new ArgumentNullException(nameof(capitalsGameRepository));
        }

        public ActionResult<IEnumerable<Country>> GetCountries()
        {
            var countriesFromRepo = _capitalsGameRepository.GetCountries();
            ViewBag.Country = new SelectList(_capitalsGameRepository.GetCountries(),  "CountryName", "CountryId");
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
