using Microsoft.EntityFrameworkCore;
using PDI.RestAPI_Task_Manager.WebAPI.src.Classes;
using PDI.RestAPI_Task_Manager.WebAPI.src.Interfaces;
using PDI.RestAPI_Task_Manager.WebAPI.src.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TaskContext> (db => db.UseSqlite("Data source  = tasks.db"));
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

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
