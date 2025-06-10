using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rituals.Contracts;
using Rituals.Extensions;

namespace Rituals.Runes;

public class OpenApiRune : IRune
{
    public void Extract(IServiceCollection services, IConfiguration config)
    {
        services.AddOpenApi();
    }

    public void CarveWith(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
            app.MapOpenApi();
    }
}