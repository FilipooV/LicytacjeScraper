using HtmlAgilityPack;
using LicytacjeScraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class GetOffertsTitle
    {
        public static List<string> GetTitle(string url)
        {
            var doc = GetDocument.GetDoc(url);
            var TitleNodes = doc.DocumentNode.SelectNodes("//div/h3");
            //"//h3[@class='mlc-itembox__title mlc-itembox__title-promoting']"

            var Titles = new List<string>();

            foreach (var item in TitleNodes)
            {
                var title = item.InnerText;
                Titles.Add(title);
            }

            return Titles;
        }
    }
}