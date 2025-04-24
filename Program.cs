using System;
using System.Timers;

namespace NET_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> len= DownloadString("https://www.csdn.net/","http://www.microsoft.com");
            Console.WriteLine("microsoft's len is"+len.Result);
        }
        public static async Task<int> DownloadString(string url1,string url2)
        {
            HttpClient client1 = new HttpClient();
            HttpClient client2 = new HttpClient();
            //下面这两个就是同步执行两个异步方法，就是线性工作流，执行时间是A+B
            //string s1=await client1.GetStringAsync(url1);
            //string s2=await client2.GetStringAsync(url2);
            Task<string> task1=client1.GetStringAsync(url1);
            Task<string> task2 =client2.GetStringAsync(url2);
            //这里使用await使得whenall变成线性流，同时等待两个异步方法完成！这就是组合子之一whenall,还有一个是whenany，
            //显然，这会使得执行时间变成max(A,B)!!!
            await Task.WhenAll(task1, task2);
            Console.WriteLine($"task1 is {(task1.IsCompleted?"":"not")} completed");
            return task2.Result.Length;
        }
    }
}
