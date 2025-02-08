using Bookstore.API.Services;
using Bookstore.Data;
using Bookstore.Inventory;
using Bookstore.Pay;
using Bookstore.Register;
using Bookstore.Transact;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddDataServices(builder.Configuration)
    .AddPaymentServices()
    .AddRegisterServices()
    .AddInventoryServices()
    .AddTransactServices();

builder.Services
    .AddScoped<ProcessPurchaseService>();

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
