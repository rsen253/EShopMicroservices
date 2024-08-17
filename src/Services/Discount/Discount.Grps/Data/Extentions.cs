﻿using Microsoft.EntityFrameworkCore;

namespace Discount.Grps.Data;

public static class Extentions
{
    public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        using var dbContext = scope.ServiceProvider.GetRequiredService<DiscountContext>();
        // migrate the database automatically 
        dbContext.Database.MigrateAsync();

        return app;
    }
}
