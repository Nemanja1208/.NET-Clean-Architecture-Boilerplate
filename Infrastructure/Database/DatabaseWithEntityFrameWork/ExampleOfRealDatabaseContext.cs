using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.DatabaseWithEntityFrameWork
{
    //public class ExampleOfRealDatabaseContext : DbContext
    //{
    //    public DbSet<User> Users { get; set; }

    //    public AppDbContext(DbContextOptions<AppDbContext> options)
    //    : base(options)
    //    {
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        // Seed data
    //        modelBuilder.Entity<User>().HasData(
    //            new User { Id = 1, Name = "John Doe" },
    //            new User { Id = 2, Name = "Jane Doe" },
    //            new User { Id = 3, Name = "Alice Johnson" },
    //            new User { Id = 4, Name = "Bob Smith" },
    //            new User { Id = 5, Name = "Eva Green" }
    //        );

    //        base.OnModelCreating(modelBuilder);
    //    }
    //}
}
