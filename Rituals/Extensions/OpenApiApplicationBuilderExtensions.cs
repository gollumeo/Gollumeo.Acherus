using Microsoft.AspNetCore.Builder;

namespace Rituals.Extensions;

public static class OpenApiApplicationBuilderExtensions
{
    public static void MapOpenApi(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Group Finder API v1");
            options.RoutePrefix = "swagger";
        });
    }
}