using Howarts.Api.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howarts.Api.Services.Interfaces
{
    public interface ISolicitudes
    {
        Task<IEnumerable<SolicitudShow>> ListarSolicitudes();
            Task<SolicitudShow> Solicitud(int id);
        Task<bool> Agregar(Solicitud solicitud);
        Task<bool> Editar(int id, Solicitud solicitud);
        Task<bool> Eliminar(int id); 
    }
}
