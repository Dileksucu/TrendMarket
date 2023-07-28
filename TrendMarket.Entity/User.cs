using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.Entity.Enums;

namespace TrendMarket.Entity
{
    public class User: IdentityUser
    {
        public AccountType AccountType { get; set; }
        public ICollection<Product> Products { get; set; } // Bir user'ın birden fazla product'ı vardır  . Bu sayede ilişki kurmuş olduk.

    }

    //public AccountType Test(bool isCorporate) 
    //{

    //    return isCorporate ? AccountType.Corporate : AccountType.Individual;
    
    //}
}
