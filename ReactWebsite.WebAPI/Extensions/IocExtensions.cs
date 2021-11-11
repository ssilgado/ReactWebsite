using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

public static class IocExtensions
{
    public static void ConfigureWebAPI(this IServiceCollection services)
    {
        services.AddControllers();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "ReactWebsite.WebAPI", Version = "v1" });
        });
    }
}