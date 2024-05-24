using Microsoft.EntityFrameworkCore;
using TesteApi;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var connString = configuration.GetConnectionString("PostgreSql");

builder.Services.AddControllers();
builder.Services.AddDbContext<ApiContext>(options => options.UseNpgsql(connString));
builder.Services.AddTransient<IItemRepository, ItemRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
