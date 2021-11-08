using Microsoft.Extensions.DependencyInjection;
using ReactWebsite.DataAccess;

public static class IocExtensions
{
    public static void AddDataAccess(this IServiceCollection services)
    {
        services.AddDbContext<ReactWebsiteContext>();
    }
}