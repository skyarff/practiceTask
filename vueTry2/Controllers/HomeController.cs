using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using vueTry2.Models;

namespace vueTry2.Controllers
{
    public class HomeController : Controller
    {

    public class UserInfo
        {
            public string Token { get; set; }
            public string Email { get; set; }
            public decimal UserId { get; set; }
            public string RefreshToken { get; set; }
            public decimal ExpiresIn { get; set; }
        }

    public class Game
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class LoginModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
            // Другие необходимые поля
        }

        static public string Email = "bffus@mail.ru";
        static public string pass = "1234";

        static public string accecesToken = "roma";
        static public string refreshToken = "1234";


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


        [HttpGet]
        public IActionResult GetGames()
        {


            List<Game> games = new List<Game>
            {
                new Game { Name = "Игра 1", Price = 19.99m },
                new Game { Name = "Игра 2", Price = 29.99m },
                new Game { Name = "Игра 3", Price = 39.99m }
            };

            string json = JsonConvert.SerializeObject(games);



            return Json(json);
        }


        [HttpPost]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {

            var temp = Json(new UserInfo
            {
                Token = "секретный_токен",
                Email = loginModel.Email,
                UserId = 4,
                RefreshToken = "refreshToken",
                ExpiresIn = 3600
            });

            Console.WriteLine(temp);

            return temp;
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