using ApiPedidos.Contratos;
using ApiPedidos.Queue;
using ApiPedidos.Repositories;
using ApiPedidos.Service;
using ApiProjetos.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepositoryInMemory>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IProjetoService, ProjetoService>();
builder.Services.AddSingleton<IBus, Producer>();
builder.Services.AddDbContext<PedidoContext>(opt =>{
    opt.UseNpgsql("Server=localhost;Port=5432;Database=Pedidos;User Id=postgres;Password=postgres");
});
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
