using CarCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CarCrud.DB
{
    public class databaseContext : DbContext
    {
        
        public databaseContext(DbContextOptions<databaseContext> options) : base(options) 
        { 
        }

        //criando contexto de tabela
        public DbSet<CarModel> Carro { get; set; } 
    }
}
