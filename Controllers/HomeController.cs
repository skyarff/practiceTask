using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using vueTry2.Models;

namespace vueTry2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ButtonClicked()
        {
            //Console.WriteLine("abobes");

            ////return Ok("Данные с сервера");


            //return View("Index");

            Console.WriteLine("VRABOBA");

            // Создаем объект для отправки в формате JSON
            var jsonData = new
            {
                Message = "Данные с сервера",
                Timestamp = DateTime.Now
            };

            // Возвращаем JSON-объект
            return Json(jsonData);
        }

        public IActionResult Index(string url)
        {
            if (url == "api/buttonClicked")
            {
                //return Ok("Данные с сервера");

                Console.WriteLine(url);
            }

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