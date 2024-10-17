using API.Application.Input.Receivers;
using API.Application.Input.Repositories;
using API.Application.Output.Interfaces;
using API.Infrastructure.Input.Repositories;
using API.Infrastructure.Output.Repositories;
using API.Infrastructure.Shared.Factory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<SqlFactory>();
builder.Services.AddTransient<IWriteAlunoRepository, WriteAlunoRepository>();
builder.Services.AddTransient<IReadAlunoRepository, ReadAlunoRepository>();
builder.Services.AddTransient<InsertAlunoReceiver>();

var app = builder.Build();

app.UseDeveloperExceptionPage();

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
