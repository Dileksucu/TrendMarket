using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendMarket.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string m { get; set; }
        public string Quantity { get; set; }


        public int UserId { get; set; } // bu prroperty koymamızın sebebi; User olmazsa product olmaz bundan dolayı varolma bağımlılığı user'dadır .Ondan dolayı UserId oluşturduk.
        public User User { get; set; }   // Burada bir userın bir product'ı olur diye ilişki kurduk .
        public int CategoryId { get; set; } // bu da yukarıda yazdığım nedenden dolayı; Product olmazsa cetagory olmaz.
        public Category Category { get; set; }

    }
}
