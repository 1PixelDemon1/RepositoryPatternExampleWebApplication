using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.RemoteRepository.HttpHandler
{
    public interface IHttpHandler
    {
        TResponse? Request<TResponse>(HttpMethod httpMethod, string uri, object? body = null);
        void Request(HttpMethod httpMethod, string uri, object? body = null);
    }
}
