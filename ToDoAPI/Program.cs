using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data;
using ToDoAPI.Middlewares;
using ToDoAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Add in memory db
builder.Services.AddDbContext<AppDbContext>(
                opt => opt.UseInMemoryDatabase("InMem"));

builder.Services.AddScoped<ITodoRepo, InMemoryRepo>();
builder.Services.AddScoped<ITodoService,TodoService>();

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

app.UseMiddleware<ErrorHandler>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
