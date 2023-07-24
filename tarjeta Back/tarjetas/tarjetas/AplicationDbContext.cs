using Microsoft.EntityFrameworkCore;
using tarjetas.Models;

namespace tarjetas
{
    public class AplicationDbContext: DbContext
    {

        public DbSet<TarjetaCredito> TarjetaCredito { get; set; } //mapeo el modelo con la tabla de la base de datos


        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        { 
        
        }
    }
}
