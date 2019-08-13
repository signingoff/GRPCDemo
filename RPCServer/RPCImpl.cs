using Grpc.Core;
using Helloworld;
using System.Threading.Tasks;

namespace RPCServer
{
    class RPCImpl : Greeter.GreeterBase
    {
        // 实现SayHello方法
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
        }
    }
 
}
