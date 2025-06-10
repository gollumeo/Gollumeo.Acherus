using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rituals.Contracts;

namespace Rituals.Runes;

public class HttpRune : IRune
{
    public void Extract(IServiceCollection services, IConfiguration config)
    {
        services.AddControllers();
    }

    public void CarveWith(WebApplication app)
    {
        app.MapControllers();
        app.UseAuthorization();
    }
}