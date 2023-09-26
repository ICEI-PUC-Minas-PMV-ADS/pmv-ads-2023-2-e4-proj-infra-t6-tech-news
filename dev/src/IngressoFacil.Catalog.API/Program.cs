using IngressoFacil.Catalog.API.Builders;
using IngressoFacil.Catalog.API.Commands;
using IngressoFacil.Catalog.API.Common.Converters;
using IngressoFacil.Catalog.API.Infrastructure;
using IngressoFacil.Catalog.API.Queries;
using IngressoFacil.Catalog.API.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().
    AddJsonOptions(options => {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<MovieCategoryBuilder>();
builder.Services.AddTransient<MovieCategoryCommandHandler>();
builder.Services.AddTransient<MovieCategoryQueryHandler>();
builder.Services.AddTransient<SessionQueryHandler>();
builder.Services.AddTransient<SessionRepository>();
builder.Services.AddTransient<MovieCategoryRepository>();
builder.Services.AddDbContext<CatalogContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("CatalogDB"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();

    using (var scope = app.Services.CreateScope()) {
        var context = scope.ServiceProvider.GetRequiredService<CatalogContext>();

        await context.Database.MigrateAsync();
        await new CatalogContextSeed().SeedAsync(context);
    }
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

