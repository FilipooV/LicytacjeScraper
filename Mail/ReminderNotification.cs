using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicytacjeScraper;

namespace LicytacjeSraper
{
    public class ReminderEmail
    {
        public static void Remind(string url)
        {

            var endTime = GetEndData.GetTime(url); //Konczy sie 08 listopada licytacja

            var ParsedTime = DateTime.Parse(endTime[0]) - DateTime.Now;

            var AcctualDate = DateTime.Now; //3.11
                                            //Więc jesli data terazniejsza bedzie 7.11 to ma wypisac ze blisko 

            Console.WriteLine("tutaj odjety czas " + ParsedTime.ToString() + GetOffertsHrefs.GetHrefs(url).ToString());



        }
    }
}
