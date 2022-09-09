using CoursJWTApiRestFull.Interfaces;
using CoursJWTApiRestFull.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Création des Politiques CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("react", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

// Création du service pour l'authentification
builder.Services.AddAuthentication(a =>
{
    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}
).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ValidIssuer = "m2i",
        ValidAudience = "m2i",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto"))
    };
});

// Add JWT Service
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("admin", police =>
    {
        police.RequireClaim(ClaimTypes.Role, "admin");

    });
    options.AddPolicy("user", police =>
    {
        police.RequireClaim(ClaimTypes.Role, "user", "admin");
    });
});


// Injection de notre service TokenService
builder.Services.AddScoped<ITokenServices,TokenService>();

//// Ajout Service Entity
//builder.Services.AddDbContext<DataDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Ajout du service Authentication à l'application
app.UseAuthentication();
// Ajout du service Authorization à l'application
app.UseAuthorization();
// Ajout du service CORS à l'application
app.UseCors();

app.MapControllers();

app.Run();
