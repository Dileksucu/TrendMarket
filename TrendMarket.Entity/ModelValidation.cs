using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrendMarket.Entity
{
    public class ModelValidation
    {
            //ANOTAİONS --> Validation için belirlenen kurallar bu şekilde isimlendirilir
            // gelen data da bu name alanı gerekli diye bir anotaion belirledik
            // eğer vermezse bu nesnelere cevap errormessage ile , hata mesajı döndürürüz

            [Required(ErrorMessage = "Lütfen Name alanını giriniz !")]
            [StringLength(100, ErrorMessage = "Name alanı en fazla 100 karakter girilebilir.")]
            public string Name { get; set; }

            public string Quantity { get; set; }

            [EmailAddress(ErrorMessage = "Lütfen doğru E-mail adresi giriniz.")]
            public string Email { get; set; }
        
    }


    public class Models
    {
        public string TxtValue1 { get; set; }
        public string TxtValue2 { get; set; }
        public string TxtValue3 { get; set; }
    }
}
