using Microsoft.Extensions.DependencyInjection;
using ReactWebsite.Services.Contracts;
using ReactWebsite.Services.Implementations;

namespace ReactWebsite.Services.Extensions
{
    public static class IocExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IInvoiceService, InvoiceService>();
        }
    }
}