using Microsoft.AspNetCore.Mvc;
using MvcAttiributeRouteUI.Models;

namespace MvcAttiributeRouteUI.Controllers
{
    [Route("kullanici")]
    public class UserController : Controller
    {
        private static List<User> users = new List<User>()
        {
            new User {Id=1,Name="Baran",Email="baran@mail.com"},
            new User {Id=1,Name="Ahmet",Email="ahmet@mail.com"}
        };
        [HttpGet("listele")]
        public IActionResult Liste()
        {
            ViewData["users"] = users;
            return View();
        }

        [HttpGet("ekle")]
        public IActionResult UserEkle()
        {
            return View();
        }

        [HttpPost("Guncelle")]
        public IActionResult UserEkle(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
            return RedirectToAction("Liste");

        }
        public IActionResult UserGuncelle()
        {
            return View();
        }

        [HttpPost("Guncelle")]
        public IActionResult UserGuncelle(User user)
        {
            var currentUser = users.FirstOrDefault(p => p.Id == user.Id);

            if (currentUser == null)
            {
                return NotFound();
            }
            currentUser.Name = user.Name;
            currentUser.Email = user.Email;
            return RedirectToAction("Liste");

        }
    }
}
