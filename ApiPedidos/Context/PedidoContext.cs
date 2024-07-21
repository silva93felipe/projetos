using ApiPedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetos.Context
{
    public class PedidoContext : DbContext{
        public PedidoContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem {get; set;}
    }
}