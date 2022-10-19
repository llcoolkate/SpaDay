using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            //ViewBag.user = newUser;
            return View();
        }
        public IActionResult SubmitAddUserForm(UserController newUser, string verify)
        {
            //add form submission handling code here 

        }
    }
}
