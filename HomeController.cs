using CodeChallenge.Helpers;
using CodeChallenge.Models;
using System.Web.Mvc;

namespace CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            PersonHelper.AddPerson(person);
            return View("Confirmation");
        }
    }
}
