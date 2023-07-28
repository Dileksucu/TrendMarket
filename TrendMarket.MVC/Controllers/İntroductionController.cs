using Microsoft.AspNetCore.Mvc;
using TrendMarket.Business.Interfaces;

namespace TrendMarket.MVC.Controllers
{
    public class İntroductionController : Controller
    {
        private  readonly IUserDataManager _userDataManager; //neden  private ?

        //constructor
        public İntroductionController(IUserDataManager userDataManager)
        {
            _userDataManager = userDataManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User() 
        {
            var users = _userDataManager.GetAllUsers();   //VT'nındaki user'larım geliyorum.
            return View(users);
        }

        public IActionResult Product() 
        {
            return View();  
        }

        public IActionResult OrderSummary() 
        {
            return View();
        
        }

    }
}
