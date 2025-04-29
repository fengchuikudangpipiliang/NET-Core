using System;
using System.Text;
using System.Timers;
using Microsoft.Extensions.DependencyInjection;
using LitJson;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
#pragma warning disable CRR0029
namespace NET_Core
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();

            services.AddScoped<TestController>();
            services.AddScoped<TestController1>();
            
            ConfigurationBuilder builder = new ConfigurationBuilder();
           
            builder.AddJsonFile("config.json",optional:false,true);
            
            IConfigurationRoot configRoot = builder.Build();

            services.AddOptions().Configure<Config>(e=>configRoot.Bind(e)).Configure<Proxy>(e=>configRoot.GetSection("proxy").Bind(e));
            using (var sp = services.BuildServiceProvider())
            {
                
                while (true)
                {
                    using (var sc = sp.CreateScope())
                    {
                        TestController t = sc.ServiceProvider.GetService<TestController>();
                        TestController1 t1 =  sc.ServiceProvider.GetRequiredService<TestController1>();
                        Console.WriteLine("这是新的一个scope");
                        t.Test();
                        t1.Test();
                    }
                    Console.WriteLine("按下任意键继续");
                    Console.ReadKey();
                }
            }

            string name = configRoot["name"];
            Console.WriteLine(name);
            string address=configRoot.GetSection("proxy:address").Value;
            Console.WriteLine(address);

            Console.WriteLine("------------------");
            IConfigurationSection proxy=configRoot.GetSection("proxy");
            Console.WriteLine(proxy.Exists());
            IConfigurationSection address1 = configRoot.GetSection("proxy:address");
            Console.WriteLine(address1.Value);
        }
    }
    class Config
    {
        public string Name { get; set; }
        public string age { get; set; }
        public Proxy proxy;
    }
    class Proxy
    {
        public string address { get; set; }
    }
   
}
