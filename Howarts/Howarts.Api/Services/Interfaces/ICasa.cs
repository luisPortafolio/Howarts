using Howarts.Api.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howarts.Api.Services.Interfaces
{
    public interface ICasa
    {
        Task<IEnumerable<Casas>> ListarCasas();

    }
}
