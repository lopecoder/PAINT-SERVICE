using Microsoft.EntityFrameworkCore;
using Paint_Service.API.Models.Entities;

namespace Paint_Service.API.Context
{
    public class PaintServiceContext : DbContext
    {
        public PaintServiceContext(DbContextOptions<PaintServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Pintor> Pintores { get; set; }

        public DbSet<Servicio> Servicios { get; set; }
    }
}
