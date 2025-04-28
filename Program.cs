using System;
using System.Text;
using System.Timers;
using Microsoft.Extensions.DependencyInjection;
#pragma warning disable CRR0029
namespace NET_Core
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           Test t = new DerivedClass();
            t.Test1();
        }
    }
    interface IController
    {
        void Test();
    }
    class Controller 
    {
        private readonly ILog _log;
        public Controller(ILog log)
        {
            this._log = log;    
        }
        public void Test()
        {
            this._log.MyLog("sss");
        }
    }
    interface ILog
    {
        public void MyLog(string message);
    }
    class LogIm : ILog
    {
        public void MyLog(string message)
        {
            Console.WriteLine("hello"+message);
        }
    }
    class Test
    {
        public void Test1()
        {
            Console.WriteLine("test");
        }
    }
    class DerivedClass:Test
    {
        public void Test1 (){ Console.WriteLine("继承"); }
    }
}
