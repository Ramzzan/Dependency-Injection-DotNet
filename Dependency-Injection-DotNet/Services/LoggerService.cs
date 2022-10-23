using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_DotNet.Services
{
    public class LoggerService : ILoggerService
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }

}
