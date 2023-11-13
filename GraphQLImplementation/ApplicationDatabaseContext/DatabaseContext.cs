using GraphQLImplementation.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace GraphQLImplementation.ApplicationDatabaseContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("server =(localdb)\\Local; database = EstatementDB; trusted_connection = true;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<House>()
                .Property(x => x.Price)
                .HasColumnType("decimal(2, 2)");
        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<House> houses { get; set; }
        public DbSet<Person> Persons{ get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
