using System;
using System.Text;
using System.Timers;
using Microsoft.Extensions.DependencyInjection;
using LitJson;
#pragma warning disable CRR0029
namespace NET_Core
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                string jsonStr = await File.ReadAllTextAsync(@"C:\Users\Lenovo\source\repos\NET Core\TextFile1.txt");

                JsonData data = JsonMapper.ToObject(jsonStr);
                JsonData data1 = data["employees"];
                JsonData data2 = data1[0];
                JsonData data3 = data2["firstName"];
                Console.WriteLine(data3.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Company
    {
        public string name;
        public string createTime;
        public bool isShanghai;
        public int registerMoney;
        public Employee[] employees;
        public override string ToString()
        {
            return string.Format($"name:{name},createTime:{createTime}" +
                $"isShanghai:{isShanghai},registerMoney:{registerMoney}");
        }
    }
}
