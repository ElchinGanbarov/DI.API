using DI.API.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddTransient<IRandomGenerator,RandomGenerator>();
//builder.Services.AddTransient<IRandomGenerator2, RandomGenerator2>();


//builder.Services.TryAddTransient<IAccountNumberClient, AccountNumberClient>();

builder.Services.AddKeyedTransient<IAccountNumberClient, AccountNumberClient>("1");

builder.Services.AddKeyedTransient<IAccountNumberClient, DefaultAccountNumber>("2");

builder.Services.AddTransient<AccountService>();

builder.Services.AddTransient<TransactionService>();

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
