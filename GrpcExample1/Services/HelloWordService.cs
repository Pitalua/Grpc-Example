using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcExample1.Services
{
    class HelloWordService: Saludador.SaludadorBase
    {
        //private readonly ILogger<HelloWordService> logger;

        //public HelloWordService(ILogger<HelloWordService>logger)
        //{
        //    this.logger = logger;
        //}

        public override Task<HelloWordResivido> Saludo(HelloWordEnviado request, ServerCallContext context)
        {
            HelloWordResivido salida = new  HelloWordResivido();

           salida.Message = "hola desde el Servidor...\n"+ request.HelloWord ;

            return Task.FromResult(salida) ;
        }

    }
}
