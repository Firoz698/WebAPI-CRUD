using Microsoft.EntityFrameworkCore;
using PracticeAspDotNet.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefultConnection"));
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

// Add services to the container.

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
