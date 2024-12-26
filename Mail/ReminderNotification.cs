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
        public static void Remind(string url, int j)
        {

            //logika aplikacji? - ??? 
            //Bo t

            var endTime = GetEndData.GetTime(url); //Konczy sie 08 listopada licytacja

            var ParsedTime = DateTime.Parse(endTime[j]) - DateTime.Now;

            DateTime endTimeParsed = DateTime.Parse(endTime[j]);

            DateTime acctualDate = DateTime.Now; //3.11
                                            //Więc jesli data terazniejsza bedzie 7.11 to ma wypisac ze blisko 

            var HowManyLeft = (endTimeParsed - acctualDate).Ticks;

            
            //Sprawdzamy czy data jest rowna jakiejś liczbie
            //np. Jesli data licytacji "19.11" - "15.11" jest równa 1 to aukcja sie zaraz kończy a jak jest równa innej to aukcja trwa jeszcze kilka dni

            if (HowManyLeft.Equals(0))
            {
                Console.WriteLine("Licytacja dobiega końca");
            }
            {
                Console.WriteLine("Licytacja jeszcze będzie trwać kilka dni");
            }
        }
    }
}
