using Microsoft.EntityFrameworkCore;
namespace ApiEstudantes.models
{
    public class ConexaoContext : DbContext
    {
        public DbSet<Estudante> Estudante{get;set;}
        public ConexaoContext(DbContextOptions<ConexaoContext> options)
            :base(options)
        {
            
        }
    }
}