using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication1.Clients
{
    public class RedditClient
    {
        private HttpClient _client;
        private static string _address;
        private static string _apikey;

        public RedditClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;

            _client = new HttpClient();
            _client.BaseAddress = Uri(_address);
            //_client.DefaultRequestHeaders.
        }

        public async Task GetTopSR()
        {
            var responce = await _client.GetAsync();
            responce.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonContent.
        }
    }
}
