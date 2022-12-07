using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace GrinchProject.Models;

public partial class GrinchContext : DbContext
{
    public GrinchContext()
    {
    }

    public GrinchContext(DbContextOptions<GrinchContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<Friend> Friends { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DbConnectionString"].ToString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Characte__3214EC07ECD45454");

            entity.ToTable("Character");

            entity.HasOne(d => d.Place).WithMany(p => p.Characters)
                .HasForeignKey(d => d.PlaceId)
                .HasConstraintName("FK__Character__Place__267ABA7A");
        });

        modelBuilder.Entity<Friend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Friend__3214EC07B4EC05B0");

            entity.ToTable("Friend");

            entity.HasOne(d => d.Character).WithMany(p => p.FriendCharacters)
                .HasForeignKey(d => d.CharacterId)
                .HasConstraintName("FK__Friend__Characte__2A4B4B5E");

            entity.HasOne(d => d.FriendCharacter).WithMany(p => p.FriendFriendCharacters)
                .HasForeignKey(d => d.FriendCharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Friend__FriendCh__29572725");
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Place__3214EC072BCC0747");

            entity.ToTable("Place");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
