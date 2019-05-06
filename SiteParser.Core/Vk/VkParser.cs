using AngleSharp.Html.Dom;
using SiteParser.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiteParser.Core.Vk
{
    public class VkParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("h2");

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
