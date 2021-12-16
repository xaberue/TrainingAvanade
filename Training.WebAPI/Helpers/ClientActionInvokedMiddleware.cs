using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Training.WebAPI.Helpers
{
    public class ClientActionInvokedMiddleware : IMiddleware
    {

        private readonly ILogger _logger;


        public ClientActionInvokedMiddleware(ILogger<ClientActionInvokedMiddleware> logger)
        {
            _logger = logger;
        }


        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var clientName = context.User?.Identity?.Name ?? string.Empty;

            if(!string.IsNullOrEmpty(clientName))
                _logger.LogInformation($"Client requested access to our API: {clientName}");

            await next(context);
        }
    }
}
