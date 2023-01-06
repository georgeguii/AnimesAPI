using AnimesAPI.DAL;
using AnimesAPI.DAL.DAO;
using AnimesAPI.DAL.Entities;
using AnimesAPI.DAL.DAO.BaseDAO;

using AnimesAPI.Utils.Mappers;

using AnimesAPI.Repository;
using AnimesAPI.Repository.Interfaces;
using AnimesAPI.Manager.Interfaces;
using AnimesAPI.Manager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<AnimesDbContext>();

builder.Services.AddScoped<IDAO<Anime>, AnimeDAO>();
builder.Services.AddScoped<IAnimeManager, AnimeManager>();
builder.Services.AddScoped<IAnimeRepository, AnimeRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AnimeProfile));

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
