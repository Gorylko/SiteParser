using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiteParser.Core.Interfaces;

namespace SiteParser.Core.Habra
{
    class HabraSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://habr.com/ru/";

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
