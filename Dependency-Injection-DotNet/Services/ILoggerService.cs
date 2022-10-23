using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_DotNet.Services
{
    public interface ILoggerService
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);

    }
}
