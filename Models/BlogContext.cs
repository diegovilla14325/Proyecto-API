using Microsoft.EntityFrameworkCore;

namespace angular.Models
{
    public partial class BlogContext : DbContext
    {
        public BlogContext()
        {
        }

        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Post> Post { get; set; }
        //public virtual DbSet<Rol> Rol { get; set; }
        //public virtual DbSet<Usuario> Usuario { get; set; }
        //public virtual DbSet<Usuariorol> Usuariorol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=Blog;Username=postgres;Password=diegob117");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .HasDefaultSchema("public")
            .Entity<Post>()
            .ToTable("post")
            .HasKey(r => r.id); 

            /*modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("rol");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombrerol)
                    .IsRequired()
                    .HasColumnName("nombrerol");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnName("contraseña");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioId)
                    .IsRequired()
                    .HasColumnName("usuario_id");
            });

            modelBuilder.Entity<Usuariorol>(entity =>
            {
                entity.ToTable("usuariorol");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuariorol)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rol");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Usuariorol)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario");
            });*/

            
        }
    }
}
