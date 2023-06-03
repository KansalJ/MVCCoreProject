using Microsoft.AspNetCore.Mvc;
using MvcCoreProject.Models.Domain;

namespace MvcCoreProject.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.greeting = "Hello World ViewBag in my Controller";
            ViewData["greeting2"] = "I am using ViewData in my Controller ";
            //ViewBag and ViewData can send data only from ControllerToView

            TempData["greeting3"] = "I am using TempData in my Controller ";
            //Tempdata can send data from one controller method to another controller method

            return View();
        }
        
        
        //this is a get method
        public IActionResult AddPerson()
        {
            return View();
        }


        //this is a HttpPost method
        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            return View();
        }
    }
}
