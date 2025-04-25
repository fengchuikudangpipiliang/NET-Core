using System;
using System.Text;
using System.Timers;

namespace NET_Core
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i <10000; i++)
            {
                stringBuilder.Append("asdfasdfasfdasdf");
            }
            //反正await等待期间，这个线程用不了
            //所以.NET就把这个线程返回到线程池，直到这个异步方法执行完毕，再取出一个线程来执行接下来的代码
            //优化：如果等待时间很短，就没必要切换线程
            await File.WriteAllTextAsync(@"D:\code\c#\hhhh.txt", stringBuilder.ToString());
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
