using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LicytacjeSraper
{
    public class SendEmail
    {
        public static void Email(string url)
        {
            //Klasa zrobiona do wysyłania maili na konta podanych tutaj

            var getUrl = GetOffertsHrefs.GetHrefs(url);
            var Date = GetEndData.GetTime(url);
            
            
            //Konto z którego jest to wysyłane
            string fromMail = "pokemonykonto14@gmail.com";
            //Hasło do aplikacji Scraper, ustawione w koncie gmail
            string fromMailPass = "rmks gvga wrrq tfmx";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            //TOPIC
            message.Subject = "Nowa oferta";
            //Mail na który mam wysłać wiadomość
            message.To.Add(new MailAddress("pokemonykonto12@gmail.com"));
            message.Body = $"Na licytacje wpadł nowy  <br>" + "https://allegrolokalnie.pl/" + getUrl[0] + "<br>" +
                "Data zakończenia licytacji: " + Date[0]; // getURL[index] - akurat tutaj na potrzeby testu wypisuje pierwsza znaleziona oferte
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromMailPass),
                EnableSsl = true,
            };
            smtpClient.Send(message);

        }
    }
}
