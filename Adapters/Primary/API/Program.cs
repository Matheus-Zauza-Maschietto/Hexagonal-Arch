using Application;
using Domain.Primary.Ports;
using Infra.Data;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseDefaultConnection")));
builder.Services.AddApplicationService();
builder.Services.AddApplicationRepositories();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

 
