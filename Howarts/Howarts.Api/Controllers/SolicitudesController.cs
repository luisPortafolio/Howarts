using Howarts.Api.Datos;
using Howarts.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Howarts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
        private readonly ISolicitudes _solicitudes;
        private readonly ICasa casa;

        public SolicitudesController(ISolicitudes solicitudes,ICasa casa)
        {
            _solicitudes = solicitudes;
            this.casa = casa;
        }
        // GET: api/<SolicitudesController>
        [HttpGet]
        public async Task<IEnumerable<SolicitudShow>> Get()
        {
            return await _solicitudes.ListarSolicitudes();            
        }

        // GET api/<SolicitudesController>/5
        [HttpGet("{id}")]
        public async Task<SolicitudShow> Get(int id)
        {
            return await _solicitudes.Solicitud(id);
        }

        // POST api/<SolicitudesController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Solicitud solicitud)
        {
            if (!ModelState.IsValid)
                return false;
            return await _solicitudes.Agregar(solicitud);
        }

        // PUT api/<SolicitudesController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(int id, [FromBody] Solicitud value)
        {
            if (!ModelState.IsValid)
                return false;
            return await _solicitudes.Editar(id,value);
        }

        // DELETE api/<SolicitudesController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _solicitudes.Eliminar(id);
        }
        [HttpGet]
        [Route("/Casas")]
        public async Task<IEnumerable<Casas>> GetCasas()
        {
            return await casa.ListarCasas();
        }
    }
}
