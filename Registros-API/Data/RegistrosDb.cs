using dataBase;
using Microsoft.EntityFrameworkCore;

namespace Registros_API.Data
{
    public class RegistrosDb: DbContext
    {
        
        public DbSet<Registros> registro { get; set; }

        public RegistrosDb(DbContextOptions<RegistrosDb> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Registros>().HasData(
              new
              {
                  StudentId = Guid.NewGuid().ToString(),
                  nome = "Jane",
                  sobrenome = "Smith",
                  senha = "Medicine"
              }
            );
        } 
    }
}
