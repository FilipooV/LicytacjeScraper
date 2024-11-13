using HtmlAgilityPack;
using LicytacjeScraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class GetDocument
    {
            public static HtmlDocument GetDoc(string url)
            {
                var web = new HtmlWeb();
                HtmlDocument doc = web.Load(url);
                return doc;
            }
    }
}