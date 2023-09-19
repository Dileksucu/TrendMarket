using Microsoft.AspNetCore.Mvc;

namespace TrendMarket.MVC.Controllers
{
    public class DataRetrievalController : Controller
    {
        //Entityler
        public class Model
        {
            public string TxtValue1 { get; set; }
            public string TxtValue2 { get; set; }
            public string TxtValue3 { get; set; }
        }

        public class ModelWithProduct
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Quantity { get; set; }
        }


        //form ile veri alma
        [HttpPost]
        public IActionResult ProductAction( ModelWithProduct Model) 
        { 
            return View();
        }



        public class QueryData 
        {
            public string A { get; set; }
            public string B { get; set; }

        }

        //Query string ile veri alma
        //public IActionResult ActionResult(string a, string b) 
        public IActionResult ActionResult(QueryData data)
        {
            //var quertString = Request.QueryString;
            //// Request yapılan endpoint'e query string parametresi eklenmiş mi eklenmemiş mi
            //// bununla ilgili bilgi verir .

            //var a= Request.Query["a"].ToString();
            //var b = Request.Query["b"].ToString();
            //// request ile verilere erişmek için bu yöntem de kullanılabilir.

            return View();

        }


        //Route Parametresiyle veri alma 

        public class RouteData
        {
            public int Id { get; set; }
            //public string a { get; set; }
            //public string b { get; set; }

        }

        //public IActionResult RouteAction(RouteData data)
        public IActionResult RouteAction() 
        {
            //Route için
            //var  values = Request.RouteValues; 

            //header ile veri alma --> buraya istedği postman üzerinden atıyoruz.
            var header = Request.Headers.ToList();
            return View();
        
        }



        //Burada CRUD işlemlerini yapıcam (Create-Read olduktan sonra Update ya da Delete yapılır.)


        //Action'ların Default hali get ile çalışır.
        //Yani biz bu action methodlara CRUD işlemleri gerçekleştirseydik kabul etmezlerdi. (Post işlemi olduğu için )

        //public IActionResult CreateProduct()
        //{
        //    //Bu action Get işlemlerini alır .(Default hali)
        //    return View();

        //}

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



        //Bu işlemleri yaptıktan sonra ;  bu verileri kullanıcının gönderdiği verileri ile entitydeki product classını bind edebilmek için 
        // CreateProduct.cshtml view classında bir using ekliyoruz ve her input'a "asp-for="Property ismini yazıyoruz".

    }
}
