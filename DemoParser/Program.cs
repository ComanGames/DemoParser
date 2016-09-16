using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ParsingData> parsingResult = new List<ParsingData>();
            List<string> ArticlesToParse = new List<string>();
            ArticlesToParse.Add("https://en.wikipedia.org/wiki/1820_in_paleontology");
            ArticlesToParse.Add("https://en.wikipedia.org/wiki/Belmont,_Auckland");
            ArticlesToParse.Add("https://en.wikipedia.org/wiki/Open-source_warfare");
            ArticlesToParse.Add("https://en.wikipedia.org/wiki/The_Coles");
            parsingResult = WebParser.ParsePage(ArticlesToParse);

            Console.ReadKey();
        }
    }
}
