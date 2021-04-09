using Howarts.Api.Datos;
using Howarts.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howarts.Api.Services.Inplementations
{
    public class Casa : ICasa
    {
        public async Task<IEnumerable<Casas>> ListarCasas()
        {
            return context.Casas.ToList();
        }
    }
}
