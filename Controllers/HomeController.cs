using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RetoTecnicoDiegoNoblecilla.Models;

namespace RetoTecnicoDiegoNoblecilla.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RandomUserService _randomUserService;

        public HomeController(ILogger<HomeController> logger, RandomUserService randomUserService)
        {
            _logger = logger;
            _randomUserService = randomUserService;
        }

        public async Task<IActionResult> Index()
        {
            var apiResponse = await _randomUserService.GetRandomUsersAsync(10);

            var results = apiResponse.Results;
            
            return View(results);
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
