using Grpc.Core;
using Helloworld;
using System;

namespace RPCClient
{

    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:8090", ChannelCredentials.Insecure);

            var client = new Greeter.GreeterClient(channel);
            HelloReply reply = client.SayHello(new HelloRequest { Name = ""});
            Console.WriteLine("来自" + reply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
