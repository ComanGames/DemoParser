namespace DemoParser
{
    public class ParsingData
    {
        public string ArticleName;

        public string ArticleText;

        public ParsingData(string articleName, string articleText)
        {
            ArticleName = articleName;
            ArticleText = articleText;
        }

        public override string ToString()
        {
            return $"ArticleName: {ArticleName}, ArticleText: {ArticleText}";
        }
    }
}