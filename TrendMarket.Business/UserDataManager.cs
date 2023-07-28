using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.Business.Interfaces;
using TrendMarket.DataAccess.Context;
using TrendMarket.Entity;

namespace TrendMarket.Business
{
    public class UserDataManager: IUserDataManager
    {
        private readonly TrendMarketDbContext _context; //private ile başlayan propertyilerin değişkenleri "_" ile başlar . Ör: _context

         //Constructor
        public UserDataManager(TrendMarketDbContext context)
        {
            _context = context;
        }


        public List<User> GetAllUsers() 
        {
            return _context.Users.AsNoTracking().ToList();

            //AsNoTracking() --> VT'dan toplu veri çekerken performans sağlar.Bütün user almamızı sağlar.
        }

    }
}
