using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProxyKit
{
    public delegate Task<HttpResponseMessage> HandleProxyRequest(HttpContext httpContext);
}