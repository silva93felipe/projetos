using ApiProjetos.Context;
using ApiProjetos.Contratos;
using ApiProjetos.Repositories;
using ApiProjetos.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProjetoRepository, ProjetoRepository>();
builder.Services.AddScoped<IProjetoService, ProjetoService>();
builder.Services.AddDbContext<ProjetoContext>(opt => {
    opt.UseNpgsql("Server=localhost;Port=5432;Database=Projetos;User Id=postgres;Password=postgres");
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
