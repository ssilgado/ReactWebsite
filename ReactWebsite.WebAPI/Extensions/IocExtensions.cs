using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using ReactWebsite.Services.Extensions;
using ReactWebsite.Services.Mappings;

public static class IocExtensions
{
    public static void ConfigureWebAPI(this IServiceCollection services)
    {
        services.AddControllers().AddNewtonsoftJson();

        services.RegisterServices();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "ReactWebsite.WebAPI", Version = "v1" });
        });

        services.AddAutoMapper(typeof(InvoiceProfile));
    }
}