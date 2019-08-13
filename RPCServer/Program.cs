using Grpc.Core;
using Helloworld;
using System;

namespace RPCServer
{
    class Program
    {
        const int Port = 8090;
        public static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { Greeter.BindService(new RPCImpl()) },
                Ports = { new ServerPort("127.0.0.1", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("gRPC server listening on port " + Port);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
