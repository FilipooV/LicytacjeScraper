using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class GetOffertsPrice
    {
        public static List<string> GetPrice(string url)
        {
            var doc = GetDocument.GetDoc(url);
            var PriceNodes = doc.DocumentNode.SelectNodes("//span[@class='ml-offer-price__dollars']");

            var Prices = new List<string>();

                foreach (var item in PriceNodes)
                {
                    var price = item.InnerText;
                    Prices.Add(price);
                }

                return Prices;
        }
    }
}
