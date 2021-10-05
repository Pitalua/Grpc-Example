using System;

namespace GrpcExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerExam server = new ServerExam();
            server.Start();
            Console.WriteLine("Servidor Corriendo...");
            Console.WriteLine("Precione una tecla para para el servidor...");
            Console.ReadKey();

        }
    }
}
