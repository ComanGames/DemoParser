using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using HtmlAgilityPack;

namespace DemoParser
{
    public static class WebParser
    {
        public static List<ParsingData> ParsePage(List<string> articlesToParse)
        {
            List<ParsingData> result = new List<ParsingData>();
            foreach(string address in articlesToParse )
            {
                Console.WriteLine("Start parsign Address " + address);
                string dataFromPage;
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(address);
                using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
                {
                    using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                        dataFromPage = stream.ReadToEnd();
                }
                Console.WriteLine("Html is loaded" + address);

                HtmlDocument html = new HtmlDocument();
                html.LoadHtml(dataFromPage);
                string articleName = html.GetElementbyId("firstHeading").InnerText;
                Console.WriteLine("Name of article getted" + address);
                
                string articleText = html.GetElementbyId("mw-content-text").Descendants("p").ToArray()[0].InnerText;

                ParsingData parsingData = new ParsingData(articleName,articleText);
                result.Add( parsingData);
                Console.WriteLine(parsingData);
                Console.WriteLine();
            }
            return result;
        }
    }
}