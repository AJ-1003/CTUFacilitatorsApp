using Microsoft.AspNetCore.Mvc;

namespace CTUFacilitatorsApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "Hello";
        //}
    }
}
