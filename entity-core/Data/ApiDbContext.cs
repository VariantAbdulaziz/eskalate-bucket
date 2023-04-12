using System;
using EntityCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityCore.Data;

public class ApiDbContext : DbContext
{
    public virtual DbSet<Driver> Drivers { get; set; } = null!;
    public virtual DbSet<Team> Teams { get; set; } = null!;
    public virtual DbSet<DriverMedia> DriverMedias { get; set; } = null!;
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Driver>(entity => {
            entity.HasOne(t => t.Team)
                .WithMany(d => d.Drivers)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("Fk_Driver_Team");

            entity.HasOne(dm => dm.DriverMedia)
                .WithOne(d => d.Driver)
                .HasForeignKey<DriverMedia>(x => x.DriverId);
        });

        modelBuilder.Entity<DriverMedia>(entity => {

            entity.HasOne(dm => dm.Driver)
                .WithOne(d => d.DriverMedia)
                .HasForeignKey<DriverMedia>(x => x.DriverId);
        });
    }
}