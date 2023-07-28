using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TrendMarket.Entity;
using TrendMarket.Entity.Enums;
using TrendMarket.MVC.Models;

namespace TrendMarket.MVC.Controllers
{
    public class UsersController : Controller
    {
        //Signup - Kayıt Olmak

        private readonly UserManager<User> _userManager;
        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet] 
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupDto dto)
        {
            var user = new User
            {
                UserName =dto.Name,
                Email = dto.Email,
                AccountType = (AccountType)Convert.ToInt32(dto.AccountType)
            };

            if (dto.Password == dto.RenewPassword) 
            {
                var result = await _userManager.CreateAsync(user, dto.Password);

            }
            return View();

            //Task<IActionResult> -->
            //async Task<IActionResult> -->
            //await _userManager.CreateAsync(user, dto.Password); -->
        }


    }
}
