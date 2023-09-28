using Coravel;
using IngressoFacil.Authentication.API.Builders;
using IngressoFacil.Authentication.API.Commands;
using IngressoFacil.Authentication.API.Infrastructure;
using IngressoFacil.Authentication.API.Queries;
using IngressoFacil.Authentication.API.Repositories;
using IngressoFacil.Authentication.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMailer(builder.Configuration);
builder.Services.AddTransient<UserBuilder>();
builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<PasswordService>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<RefreshTokenRepository>();
builder.Services.AddTransient<EmailService>();
builder.Services.AddTransient<ConfirmationTokenService>();
builder.Services.AddTransient<AuthenticationCommandHandler>();
builder.Services.AddTransient<AuthenticationQueryHandler>();
builder.Services.AddDbContext<AuthContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthDB"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
