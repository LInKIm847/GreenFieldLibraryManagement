using GreenFieldLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenFieldLib.Controllers
{
    public class LibraryController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(LibraryBook book)
        {
            return View("Confirmation", book);
        }
    }
}
