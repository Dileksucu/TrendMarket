using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.DataAccess.Context;
using ent=TrendMarket.Entity;

namespace TrendMarket.Business.Operation.Product
{
    public class ProductOperation<T> where T : class
    {
        public Repository<ent.Product>  _productRepo{ get; set; }


        //ctor
        public ProductOperation(Repository<ent.Product> productRepo) {
           this._productRepo = productRepo;
        }

       // var blogWithComments =  DbContext.Include(b => b.productRepo).FirstOrDefaultAsync();

        public void GetById(string id) {
           
            if (id !=null)
            {
                //Vt nından gelen id ile girdiğimiz id karşılaştırıcaz eğer eşleşiyorsa crud işlemi yapıcaz.
                

            }

             _productRepo.GetById(id); ;
        }
    }
}
