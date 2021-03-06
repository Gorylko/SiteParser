﻿using SiteParser.Core.Interfaces;

namespace SiteParser.Core.KinoPoisk
{
    public class KinoSettings : IParserSettings
    {
        public KinoSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://www.kinopoisk.ru/top/";

        public string Prefix { get; set; } = "";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
