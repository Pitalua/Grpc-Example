using Grpc.Core;
using GrpcExample1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcExample1
{
    class ServerExam
    {
        public readonly Server ser;

        public ServerExam()
        {
            ser = new Server()
            {
                Services = { Saludador.BindService(new HelloWordService()) },
                Ports = { new ServerPort("localhost",11111, ServerCredentials.Insecure)}
            };

        }

        public void Start()
        {
            ser.Start();
        }

        public async Task ShutDownAsync()
        {
            await ser.ShutdownAsync();
        }
    }
}
