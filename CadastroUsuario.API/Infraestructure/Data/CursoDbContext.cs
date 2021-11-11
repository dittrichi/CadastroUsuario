using CadastroUsuario.API.Business.Entities;
using CadastroUsuario.API.Infraestructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuario.API.Infraestructure.Data
{
    public class CursoDbContext : DbContext
    {
        public CursoDbContext(DbContextOptions<CursoDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<CadastroUsuario.API.Business.Entities.Curso> Curso { get; set; }
    }
}