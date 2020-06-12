using Kafka.consumer.console;
using Kafka.consumer.console.Models;
using Microsoft.EntityFrameworkCore;
namespace Kafka.consumer.console.TestDb
{
    public class TestDbContext : DbContext
    {
        public DbSet<TopicMessages> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<TopicMessages>().HasKey(m => m.key);
            //builder.Entity<TopicMessages>().HasNoKey();
            builder.Entity<TopicMessages>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string constr = Utility.GetConnectionString("ConnectionStrings:DefaultConnection");
            optionsBuilder.UseNpgsql(constr);
        }
    }
}