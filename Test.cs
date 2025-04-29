using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Core
{
    public class Test
    {
        private readonly ILogger<Test> logger;
        public Test(ILogger<Test> logger)
        {
            this.logger = logger;
        }
        public void Log()
        {
            logger.LogDebug("开始登录无限火力");
            logger.LogWarning("登录失败..");
        }
    }
}
