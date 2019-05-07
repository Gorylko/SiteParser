using AngleSharp.Html.Dom;
using SiteParser.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiteParser.Core.KinoPoisk
{
    public class KinoParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("all") && item.TextContent.Contains("("));

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
