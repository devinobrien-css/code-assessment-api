using code_assessment_api.Data;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Identity.Extensions;

public static class MigrationExtensions 
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();
        using ApplicationDbContext context = scope. ServiceProvider.GetRequiredService<ApplicationDbContext>();
        context.Database.Migrate();
    }
}