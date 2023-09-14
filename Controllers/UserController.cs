using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAppUser.Models;

namespace WebAppUser.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="Praveen",UserPwd="tdaa5785",UserEmail="praveensrini2001@gmail.com"},
            new User(){UserId=2,UserName="Siva",UserPwd="mdjj3737",UserEmail="siva2001@gmail.com"},
            new User(){UserId=3,UserName="Shyam",UserPwd="iidd3423",UserEmail="shyam@gmail.com"}
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }
    }
}
