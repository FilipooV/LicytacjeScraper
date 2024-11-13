using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class SearchingSystem
    {
        public static String System()
        {
            String url;
            Console.WriteLine("Podaj system wyszukiwania 1 albo 2");
            int Chosen = Convert.ToInt32(Console.ReadLine());
            
            switch (Chosen)
            {
                case 1:
                    string TypeOfSearching = Console.ReadLine();

                    
                    
                    url = $"https://allegrolokalnie.pl/oferty/q/{TypeOfSearching}?typ=licytacja";
                    break;
                case 2:
                    url = "https://allegrolokalnie.pl/oferty/elektronika?typ=licytacja";
                    break;
                default:
                    url = "https://allegrolokalnie.pl/oferty/elektronika?typ=licytacja";
                    break;

            }
            return url;
        }
    }
}
