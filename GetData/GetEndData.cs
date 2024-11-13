using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class GetEndData
    {
        public static List<string> GetTime(string url)
        {
            var doc = GetDocument.GetDoc(url);
            var TimeNodes = doc.DocumentNode.SelectNodes("//span[@data-mlc-itembox-bidding-remaining-time]");

            var Time = new List<string>();


            //OGARNNIJ POBIERANIE SAMEJ DATY
            foreach (var TimeNode in TimeNodes)
            {
                var time = TimeNode.GetAttributeValue("data-mlc-itembox-bidding-remaining-time", string.Empty);
                
                 //WYCIĘTA DATA - 
                //Wycieta data - dzień, miesiąc, rok
                string extracedDate = time.Substring(28, 10);
                //Wycięta godzina 
                string extracedHour = time.Substring(39, 8);
                //Cały złączony link
                var fullUrl = extracedDate+ " " + extracedHour;

                var ParsedUrl = DateTime.Parse(fullUrl);
                var AddedHour = ParsedUrl.AddHours(1);

                Time.Add(AddedHour.ToString());
            }
            return Time;
        }
    }
}
