using Artists.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Artists.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private IEnumerable<Picture> pictures = new List<Picture>
        {
            new Picture()
            {
                Id = 1,
                Name="Мадонна Конестабіле",
                Year= 1504,
                Logo="https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Raffael_024.jpg/180px-Raffael_024.jpg"
            },
        new Picture()
        {
            Id = 2,
                Name = "Заручини Діви Марії.",
                Year = 1504,
                Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Raffaello_-_Spozalizio_-_Web_Gallery_of_Art.jpg/125px-Raffaello_-_Spozalizio_-_Web_Gallery_of_Art.jpg"
            },
         new Picture()
            {
                Id = 3,
                Name="Портрет Маддалени Доні.",
                Year= 1506,
                Logo="https://upload.wikimedia.org/wikipedia/commons/thumb/3/37/Raphael_-_Maddelena.jpg/124px-Raphael_-_Maddelena.jpg"
            },
         new Picture()
            {
                Id = 4,
                Name="Мадонна Темпі.",
                Year= 1507,
                Logo="https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Tempi_Madonna_by_Raffaello_Sanzio_-_Alte_Pinakothek_-_Munich_-_Germany_2017.jpg/120px-Tempi_Madonna_by_Raffaello_Sanzio_-_Alte_Pinakothek_-_Munich_-_Germany_2017.jpg"
            },
          new Picture()
            {
                Id = 5,
                Name="Мадонна з гвоздиками.",
                Year= 1512,
                Logo="https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Raphael_Madonna_of_the_Pinks.jpg/145px-Raphael_Madonna_of_the_Pinks.jpg"
            }

        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Collection()
        {
            return View(pictures);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
