


using Dependency_Injection_DotNet.Client;
using Dependency_Injection_DotNet.Services;

Console.WriteLine("Start Programe");


LoggerService logger = new LoggerService();

Client client = new Client(logger);
client.Create();

