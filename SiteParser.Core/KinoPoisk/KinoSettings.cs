using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiteParser.Core.Interfaces;

namespace SiteParser.Core.KinoPoisk
{
    public class KinoSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://www.kinopoisk.ru/top/";

        public string Prefix { get; set; } = "";

        public int StartPoint { get; set; } = 1;

        public int EndPoint { get; set; } = 2;
    }
}
