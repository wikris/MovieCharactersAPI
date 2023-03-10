using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MovieCharactersAPI.Models;
using MovieCharactersAPI.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MoviesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "MovieCharactersApi",
        Description = "Movie Character Api: Use commands Get, put, post, delete resources to manipulate database",
        Contact = new OpenApiContact
        {
            Name = "Link to repository",
            Url = new Uri("https://github.com/wikris")
        }
    });
    options.IncludeXmlComments(xmlPath);
});

builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<IFranchiseService, FranchiseService>();
builder.Services.AddTransient<ICharacterService, CharacterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
