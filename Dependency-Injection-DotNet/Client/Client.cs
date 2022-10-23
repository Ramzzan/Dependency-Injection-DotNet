using Dependency_Injection_DotNet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_DotNet.Client
{
    public class Client
    {
        private readonly ILoggerService _loggerService;
        public Client(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public void Create()
        {
            _loggerService.Info("create new client.");
        }

        public void Update()
        {
            _loggerService.Info("update client.");
            _loggerService.Warn("1 rows affected");
        }
        public void Delete()
        {
            _loggerService.Info("delete client.");
            _loggerService.Error("1 error code");
        }
    }
}
