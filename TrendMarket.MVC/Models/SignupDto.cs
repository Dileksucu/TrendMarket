using TrendMarket.Entity.Enums;

namespace TrendMarket.MVC.Models
{
    public class SignupDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RenewPassword { get; set; }
        public string AccountType { get; set; }


    }
}
