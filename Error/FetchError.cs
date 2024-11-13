using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class FetchError
    {
        public static void Error(string url)
        {
            //Proste szukanie czy dostałem bana. Trzeba dopercyzować
            //Spróbuj zrobic na try catch            
                var web = new HtmlWeb();
                HtmlDocument doc = web.Load(url);
                var ParsedDoc = doc.DocumentNode.InnerHtml;
                if (!ParsedDoc.Contains("captcha"))
                {
                    Console.WriteLine("It works! :)");
                }
                else
                {
                    Console.WriteLine("Platforms detected scrapping");
                }
            
        }
    }
}
