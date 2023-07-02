using Pizza_API.Builder.PromocionesDia;
using Pizza_API.Services.Cocina;
using Pizza_API.Services.Promocion;

var builder = WebApplication.CreateBuilder(args);


DataPromocion data = new DataPromocion();
builder.Services.AddSingleton(data);

// Add services to the container.

builder.Services.AddScoped<IPedidoCocina, PedidoCocina>();
builder.Services.AddScoped<IAplicaPromocion, AplicaPromocion>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
