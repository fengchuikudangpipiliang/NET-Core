using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace NET_Core
{
    public class MyDBContext:DbContext//逻辑上的数据库
    {
        private static ILoggerFactory loggerFactory = LoggerFactory.Create(log=>log.AddConsole());
        //数据库生成的表的名字是这里的属性名，不是实体名
        public DbSet<Book> Books { get; set; }//DBSet实现了枚举，因此可以使用Linq，EFCore会帮我们转化为sql语句
        //但是使用的肯定是efcore扩展的方法，返回类型有点变化
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //指定要链接的数据库
            base.OnConfiguring(optionsBuilder);
            /*
             Server=(local)

             连接本地数据库实例的标准写法
             也可用 . 代替 (local)，如：Server=.
             
            Integrated Security=True
             
             启用Windows身份验证（替代用户名/密码）
             等价写法：Trusted_Connection=True
             
            Encrypt=True
             
             强制启用TLS加密（对应SSMS中"加密连接"勾选）
             
            TrustServerCertificate=True
             
             绕过证书链验证（对应SSMS中"信任服务器证书"勾选）
             适用于自签名证书或测试环境
             */
            optionsBuilder.UseSqlServer("Server=(local);Database=test;TrustServerCertificate=True;Integrated Security=True;Encrypt=True;");
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
