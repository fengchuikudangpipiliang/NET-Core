using System;
using System.Timers;

namespace NET_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = CountCharacter(1,"http://www.illustratedcsharp.com");
            Task<int> task2 = CountCharacter(2,"https://www.csdn.net");
            //如果是task1.wait(),那么就是用于单一的task对象，等待task1完成再执行下面的代码
            Task[] tasks = { task1,task2};
            Task.WaitAll(tasks);
            Console.WriteLine($"task1 {(task1.IsCompleted?" ":"not")} complete");
            Console.WriteLine($"task2 {(task2.IsCompleted ? " " : "not")} complete");
            Console.WriteLine($"The count is {task1.Result}and {task2.Result}");

        }
        public static async Task<int> CountCharacter(int id,string url)
        {
            string site=await new HttpClient().GetStringAsync(url);
            return site.Length; 
        }
    }
}
