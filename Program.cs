using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using LicytacjeSraper;
using System.Net;

namespace LicytacjeScraper
{
    class Program
    {
        static void Main(string[] args) {

            //UWAGA TO JEST ŹLE - znak ' stoi w złym miejscu -             ("//h3'[@class=mlc-itembox__title mlc-itembox__title-promoting']");
            //POPRAWNE - znak ' musi stać po "class" ale przed nazwą klasy ("//h3[@class='mlc-itembox__title mlc-itembox__title-promoting']");




            String url = SearchingSystem.System();

            FetchError.Error(url);

            var doc = GetDocument.GetDoc(url);

            DisplayAllInfos.DisplayInfos(url);


            ReminderEmail.Remind(url);




        }
    }
}