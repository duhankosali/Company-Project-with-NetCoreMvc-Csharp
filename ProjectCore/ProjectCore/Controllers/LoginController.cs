using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims; // talepler
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Models;

namespace ProjectCore.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult Login()
        {
            return View();  
        }

        public async Task<IActionResult> Login(Admin admin)
        {
            var info = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password); // Kullanıcı adı ve şifrenin doğru olup olmadığını kontrol ediyor.
            
            if(info != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.UserName)
                };

                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index","Employee");
            }

            return View();
        }
    }
}
