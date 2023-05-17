using Microsoft.EntityFrameworkCore;
using WebApplication1.Entidades;

namespace WebApplication1
{
    public class Contexto : DbContext 
    {
        public Contexto( DbContextOptions<Contexto> opt ) : base( opt )
        {}

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<PermissaoEntidade> PERMISSAO { get; set; }
        


    }
}
