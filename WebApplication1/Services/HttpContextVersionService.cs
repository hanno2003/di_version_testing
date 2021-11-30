using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace WebApplication1.Services
{
    public class HttpContextVersionService : IVersionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpContextVersionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string CurrentVersion
        {
            get
            {
                _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Version", out StringValues version);
                return version;
            }
        }

        public string DefaultVersion
        {
            get
            {
                return "V2";
            }
        }
    }
}
