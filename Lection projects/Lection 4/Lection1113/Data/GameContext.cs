using Lection1113.Models;
using Microsoft.EntityFrameworkCore;

namespace Lection1113.Data;

public partial class GameContext : DbContext
{
    public GameContext()
    {
    }

    public GameContext(DbContextOptions<GameContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source = mssql; Initial Catalog = ispp3515; User ID = ispp3515; Password = 3515; Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__19093A0BCABBD70A");

            entity.ToTable("Category");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.GameId).HasName("PK__Game__2AB897FD6FC7D2AC");

            entity.ToTable("Game", tb =>
                {
                    tb.HasTrigger("trChangedGamesCount");
                    tb.HasTrigger("trDeleteGame");
                    tb.HasTrigger("trSavePrice");
                });

            entity.Property(e => e.Description).HasMaxLength(480);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.TotalKeys).HasDefaultValue(100);

            entity.HasOne(d => d.Category).WithMany(p => p.Games)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Game_Category");
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.ToTable("Photo");

            entity.Property(e => e.Path)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasMany(d => d.Tags).WithMany(p => p.Photos)
                .UsingEntity<Dictionary<string, object>>(
                    "PhotoTag",
                    r => r.HasOne<Tag>().WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PhotoTag_Tag"),
                    l => l.HasOne<Photo>().WithMany()
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PhotoTag_Photo"),
                    j =>
                    {
                        j.HasKey("PhotoId", "TagId");
                        j.ToTable("PhotoTag");
                    });
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.ToTable("Tag");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
