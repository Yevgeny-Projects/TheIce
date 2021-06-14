using System.Net.Http;
using System.Threading.Tasks;

namespace TheIce.Core
{
    public interface IHttpGetRequestSender
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }
}