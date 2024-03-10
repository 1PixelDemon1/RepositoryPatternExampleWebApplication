using GameStore.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.RemoteRepository.HttpHandler
{
    public class HttpHandler : IHttpHandler
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public TResponse? Request<TResponse>(HttpMethod httpMethod, string uri, object? body = null)
        {
            var httpClient = _httpClientFactory.CreateClient("LinkShortener");
            var message = new HttpRequestMessage(httpMethod, new Uri(uri));
            message.Headers.Add("Accept", "application/json");
            if (body is not null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            }
            var response = httpClient.Send(message);
            return JsonConvert.DeserializeObject<TResponse>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        public void Request(HttpMethod httpMethod, string uri, object? body = null)
        {
            var httpClient = _httpClientFactory.CreateClient("LinkShortener");
            var message = new HttpRequestMessage(httpMethod, new Uri(uri));
            message.Headers.Add("Accept", "application/json");
            if (body is not null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            }
            httpClient.Send(message);
        }
    }
}
