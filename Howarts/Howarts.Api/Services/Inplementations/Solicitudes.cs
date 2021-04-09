using Howarts.Api.Context;
using Howarts.Api.Datos;
using Howarts.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howarts.Api.Services.Inplementations
{
    public class Solicitudes : ISolicitudes
    {
        private readonly HowartsContext context;

        public Solicitudes(HowartsContext context)
        {
            this.context = context;
        }
        public async Task<bool> Agregar(Solicitud solicitud)
        {
            context.Solicitudes.Add(solicitud);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Editar(int id, Solicitud solicitud)
        {
            if (context.Solicitudes.Where(s => s.Id == id).Count() > 0)
            {
                context.Solicitudes.Update(solicitud);
                return await context.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        public async Task<bool> Eliminar(int id)
        {
            if (context.Solicitudes.Where(s => s.Id == id).Count() > 0)
            {
                context.Solicitudes.Where(s => s.Id == id).First().Activo = false;
                return await context.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        public async Task<IEnumerable<SolicitudShow>> ListarSolicitudes()
        {
            return context.Solicitudes.ToList()
                .Select(
                s => new SolicitudShow
                {
                    Activo = s.Activo,
                    Apellido = s.Apellido,
                    Edad = s.Edad,
                    FCreacion = s.FCreacion,
                    FEliminado = s.FEliminado,
                    FModificacion = s.FModificacion,
                    Id = s.Id,
                    Identificacion = s.Identificacion,
                    Nombre = s.Nombre,
                    Casa = s.Casas.First().Nombre
                });
        }

        public async Task<SolicitudShow> Solicitud(int id)
        {
            return context.Solicitudes.Where(s => s.Id == id).ToList().Select(
               s => new SolicitudShow
               {
                   Activo = s.Activo,
                   Apellido = s.Apellido,
                   Edad = s.Edad,
                   FCreacion = s.FCreacion,
                   FEliminado = s.FEliminado,
                   FModificacion = s.FModificacion,
                   Id = s.Id,
                   Identificacion = s.Identificacion,
                   Nombre = s.Nombre,
                   Casa = s.Casas.First().Nombre
               }).First();
        }
    }
}
