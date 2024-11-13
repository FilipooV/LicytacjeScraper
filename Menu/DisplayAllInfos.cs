using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace LicytacjeSraper
{
    public class DisplayAllInfos
    {
        public static void DisplayInfos(string url)
        {
            

            var Offerts = GetOffertsTitle.GetTitle(url);
            var Prices = GetOffertsPrice.GetPrice(url);
            var Hrefs = GetOffertsHrefs.GetHrefs(url);
            var Time = GetEndData.GetTime(url);
            
            string FullHrefs = "https://allegrolokalnie.pl";


            //SEND EMAIL
            /*SendEmail.Email(url);*/

            for (int i = 0; i < Offerts.Count; i++)
            {
                Console.WriteLine(Offerts[i] + " " + "Cena: " + Prices[i] + " zł");
                Console.WriteLine(FullHrefs + Hrefs[i]);
                Console.WriteLine("KONIEC TO: " + Time[i]);
                Thread.Sleep(10000);
            }
        }
    }
}
