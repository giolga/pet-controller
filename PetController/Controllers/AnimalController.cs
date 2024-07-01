using Microsoft.AspNetCore.Mvc;
using PetController.Models;

namespace PetController.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            Dog ledy = new Dog("Ledy", 6, "Kumi", "Woof Woof");

            return View(ledy);
        }

        public string Hello()
        {
            return "Hello who's there?";
        }
    }
}
