using ApiPedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetos.Context
{
    public class PedidoContext : DbContext{
        public PedidoContext(DbContextOptions options): base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem {get; set;}
    }
}