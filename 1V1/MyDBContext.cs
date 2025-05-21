

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace _1V1
{
    internal class MyDBContext:DbContext
    {

        private static ILoggerFactory loggerFactory = LoggerFactory.Create(log => log.AddConsole());
      
        public DbSet<Order> Orders { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(local);Database=test;TrustServerCertificate=True;Integrated Security=True;Encrypt=True;");
            //这个就是在sql的同时就可以输出在自己配置的地方
            optionsBuilder.UseLoggerFactory(loggerFactory);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //加载所有的配置->从本程序集加载所有的配置类
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
