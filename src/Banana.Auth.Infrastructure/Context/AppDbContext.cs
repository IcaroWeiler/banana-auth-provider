using Banana.Auth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Banana.Auth.Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API: Configurações finas da tabela
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("Users");
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(180);

            entity.HasIndex(e => e.Email)
                .IsUnique(); // Índice único para performance e integridade

            entity.Property(e => e.PasswordHash)
                .IsRequired();
        });
    }
}