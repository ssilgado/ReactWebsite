using Microsoft.Extensions.DependencyInjection;
using ReactWebsite.DataAccess;

namespace ReactWebsite.DataAccess.Extensions
{
    public static class IocExtensions
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddDbContext<ReactWebsiteContext>();
        }
    }
}
