using SiteParser.Core.Interfaces;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SiteParser.Core
{
    public class HtmlLoader
    {
        readonly HttpClient client;
        public string Url { get; }

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            Url = $"{settings.BaseUrl}{settings.Prefix}";
        }

        public async Task<string> GetSourceByPageId(int id = 1)
        {
            var currentUrl = Url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
