using Microsoft.EntityFrameworkCore;

namespace diego_aranda_api.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
    //      protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Users>()
    //         .HasOne(p => p.Roles)
    //         .WithMany(b => b.Users)
    //         .HasForeignKey(p => p.RoleId);
    //     modelBuilder
    //         .Entity<Roles>()
    //         .HasMany(p => p.Functionalities)
    //         .WithMany(p => p.Roles)
    //         .UsingEntity(j => j.ToTable("RolesFunctionalities"));
    // }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        
        public DbSet<Functionalities> Functionalalities { get; set; }
        

    }
        
}

// fwfs