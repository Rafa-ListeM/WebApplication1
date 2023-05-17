using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using WebApplication1.Entidades;

namespace WebApplication1
{
    public class Contexto : DbContext 
    {
        public Contexto (DbContextOptions<Contexto> opt) : base(opt) 
        { }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<PermissaoEntidade> PERMISSAO { get; set; }
        


    }
}
