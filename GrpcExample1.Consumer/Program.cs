using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace GrpcExample1.Consumer
{
    class Program
    {
        static async Task Main(string[] args)

        {
            Console.WriteLine("Ingrese un nombre");
            string nombre = Console.ReadLine();
            var input = new HelloWordEnviado { HelloWord = nombre };
            Channel channel = new Channel("localhost", 11111, ChannelCredentials.Insecure);
            Saludador.SaludadorClient client = new Saludador.SaludadorClient(channel);
            var reply = await client.SaludoAsync(input);
            Console.WriteLine(reply.Message); 
            Console.ReadLine();
        }


    }
}
