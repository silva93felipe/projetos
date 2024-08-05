using ApiProjetos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetos.Context
{
    public class ProjetoContext : DbContext{
        public ProjetoContext(DbContextOptions options) : base(options) { }
        public DbSet<Projeto> Projeto { get; set; } 
    }
}