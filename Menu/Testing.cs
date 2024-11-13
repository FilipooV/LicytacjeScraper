using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class Testing
    {
        public async Task FetchDataAsync() {
            string url = "https://api.scraperapi.com/?api_key=c93436b413aaaa41711c639e54bfc660&url=https%3A%2F%2Fallegrolokalnie.pl%2Foferty%2Fq%2Fipad%3Ftyp%3Dlicytacja";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string ResponseText = await response.Content.ReadAsStringAsync();
                    GetTitles(ResponseText);
                }
                catch(HttpRequestException e)
                {
                    Console.Write("Doesnt work");
                }
            }

        }
        public static void GetTitles(string responseText)
        {
            Console.Write(responseText);
        }
    }
}
