using SiteParser.Core.Interfaces;

namespace SiteParser.Core.Vk
{
    public class VkSettings : IParserSettings
    {
        public VkSettings(int start, int end, string id)
        {
            StartPoint = start;
            EndPoint = end;
            BaseUrl = BaseUrl.Replace("{Id}", id);
        }

        public string BaseUrl { get; set; } = "https://vk.com/{Id}";

        public string Prefix { get; set; } = "";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
