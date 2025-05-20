
using Microsoft.Extensions.Logging;

namespace NET_Core
{
    public class LogTest
    {
        private readonly ILogger<LogTest> _logger;
        public LogTest(ILogger<LogTest> logger)
        {
            this._logger = logger;
        }
        public void Log(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
