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

            //Response.Headers.Add("X-Custom-Header", "Custom Value");

            // Создаем объект для отправки в формате JSON
            var jsonData = new
            {
                Message = "Данные с сервера",
                Timestamp = DateTime.Now
            };

            // Возвращаем JSON-объект
            return Json(jsonData);
        }


        [HttpPost]
        public IActionResult CreateData([FromBody] string data)
        {
            // Логика для создания данных
            // ...

            //var responseData = new
            //{
            //    Id = data.Id,
            //    Name = data.Name,
            //    CreatedAt = DateTime.Now
            //};

            return Ok(data);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateData(int id, [FromBody] string data)
        {
            // Логика для обновления данных
            // ...

            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            // Логика для удаления данных
            // ...

            return Ok();
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