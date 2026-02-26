using BlazorCrud.Modelos;
using Microsoft.EntityFrameworkCore;



namespace BlazorCrud.Components.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }

        //Colocamos cada uno de los modelos
        public DbSet<Libro> Libro { get; set; }
    }
}
