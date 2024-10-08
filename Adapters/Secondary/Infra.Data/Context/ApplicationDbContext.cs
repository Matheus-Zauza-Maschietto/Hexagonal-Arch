using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<MeanContact> MeanContacts { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>()
        .HasMany(e => e.MeanContacts)
        .WithOne(p => p.Contact);

        modelBuilder.Entity<MeanContact>()
        .HasOne(e => e.Contact)
        .WithMany(p => p.MeanContacts);

        base.OnModelCreating(modelBuilder);
    }
}
