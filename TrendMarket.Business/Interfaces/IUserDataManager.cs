using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.Entity;

namespace TrendMarket.Business.Interfaces
{
    public interface IUserDataManager
    {
        List<User> GetAllUsers();
    }
}
