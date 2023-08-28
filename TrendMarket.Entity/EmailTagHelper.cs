using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendMarket.Entity
{
    //[HtmlAttributeName("dilek")] --> Bu tag arasına istediğimiz email tag ismi verebiliriz . BUrada verdiğimiz ismi Product.cshtml sayfasında kullandım .
    public class EmailTagHelper : TagHelper
    {
        public string Email { get; set; }
        public string? Display { get; set; } // burası view kısmını gösteren kısmında link için yazmak istediğimiz kısım.

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // context nesnesi tag helperin geldiği yer 
            // output kısmı da verinin çıktığı yer; view kısmından aldığı kısımları gösterir.
            output.TagName= "a";
            output.Attributes.Add("href",$"mailto:(Email)");
            output.Content.Append(Display);
        }
    }
}
