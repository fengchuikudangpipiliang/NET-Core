using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Core
{
    internal class TestController
    {
        private readonly IOptionsSnapshot<Config> optProxy;
        public TestController(IOptionsSnapshot<Config> optProxy)
        {
            this.optProxy = optProxy;
        }
        public void Test()
        {
            Console.WriteLine(optProxy.Value.Name);
            Console.WriteLine("*********");
        }
    }
    internal class TestController1
    {
        private readonly IOptionsSnapshot<Proxy> optProxy;
        public TestController1(IOptionsSnapshot<Proxy> optProxy)
        {
            this.optProxy = optProxy;
            
        }
        public void Test()
        {
            Console.WriteLine(optProxy.Value.address+"?");
            
            Console.WriteLine("*********");
        }
    }
}
