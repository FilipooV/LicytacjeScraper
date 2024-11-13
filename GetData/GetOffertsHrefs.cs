using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class GetOffertsHrefs
    {
        public static List<string> GetHrefs(string url)
        {
            var doc = GetDocument.GetDoc(url);
            var HrefsNodes = doc.DocumentNode.SelectNodes("//a[@class='mlc-card mlc-itembox']");

            var Hrefs = new List<string>();

            foreach (var item in HrefsNodes)
            {
                var href = item.GetAttributeValue("href", "");
                Hrefs.Add(href);
            }
            return Hrefs;
        }
    }
}


