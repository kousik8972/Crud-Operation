using System;
using Crud_Operation.Data;
using Crud_Operation.RepositoryLayer;
using Crud_Operation.ServiceLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// EF Core connection setup.
builder.Services.AddDbContext<Crud_OperationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'Crud_OperationContext' not found.")));

// Add services to the container.
builder.Services.AddControllers();

// Register dependancies
builder.Services.AddTransient<ICrudOperationSL,  CrudOperationSL>();
builder.Services.AddTransient<ICrudOperationRL, CrudOperationRL>();

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
