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

            list.Add("Кто : " + document.QuerySelectorAll("h2")[0].TextContent);
            list.AddRange(new string[] { "", "Прочая инфа :"});
            var items = document.QuerySelectorAll("a").Where(item => item.TextContent != null && item.TextContent != string.Empty);

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
