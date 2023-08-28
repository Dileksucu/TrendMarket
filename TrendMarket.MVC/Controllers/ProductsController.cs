using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrendMarket.Entity;



namespace TrendMarket.MVC.Controllers
{
    public class ProductsController : Controller
    {

        public class model
        {
            public string txtValue1 { get; set; }
            public string txtValue2 { get; set; }
            public string txtValue3{ get; set; }
        }

        public class ModelWithProduct 
        {
            
            public int Id { get; set; }
            public string Name { get; set; }
            public string Quantity { get; set; }


        }
      
        //Burada CRUD işlemlerini yapıcam (Create-Read olduktan sonra Update ya da Delete yapılır.)


        //Action'ların Default hali get ile çalışır.
        //Yani biz bu action methodlara CRUD işlemleri gerçekleştirseydik kabul etmezlerdi. (Post işlemi olduğu için )

        public ActionResult CreateProduct()
        {
            //Bu action Get işlemlerini alır .(Default hali)
            return View();

        }

        // Post olmasını nasıl sağlarız ? 
        // Biz Add işlemi yapacağımız için buradaki action tetiklenmeyecek 
        //Nedeni şu ; action methodu default get , biz post işlemi yapıyoruz.
        //Peki bu action neyi sağlar? sadece view sayfasının gelmesini sağlar .

        //[HttpPost] // --> yaptığımızda post işlemi olur.
        // public ActionResult CreateProduct(string txtProduct, string txtId)
        //public ActionResult CreateProduct(Product product) 
        //{ 
        //    //request işleminde gelen dataların hepsi Action fonksiyonlarda parametrelerden yakalamaktadır.

        //    return View();
        //// Biz bu action'ın post olduğunu belirttik.Buradaki action post işlmelerini alır .


        //// Bazı durumlar çoklu veriler gelir ; bu durumda verileri model ile karşılaman daha iyi olacaktır.
        ////Ama şöyle bir durum var , Şu var , propert'lerin hepsini karşılayack bir model oluşturmalı
        ////aksi takdir de bir tane bile property karşılanmazsa model de V-model oluşturmalı dedi hoca ileri de buna değinicez 
     
        //}

    [HttpPost] // kullanıcıdan veri alıcaz , kullanıcıdan veri alırken Post ederiz.

   
        public ActionResult CreateProduct(ModelWithProduct model) 
        {
            //veri alma action'ı
           // var value1 = data["txtValue1"].ToString(); // stringe çeviriyoruz yakalanan datayı

            return View();
        }


        //Bu işlemleri yaptıktan sonra ;  bu verileri kullanıcının gönderdiği verileri ile entitydeki product classını bind edebilmek için 
        // CreateProduct.cshtml view classında bir using ekliyoruz ve her input'a "asp-for="Property ismini yazıyoruz".


    }
}
