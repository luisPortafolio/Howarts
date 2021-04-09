using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Howarts.Api.Datos
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public DateTime FCreacion { get; set; }
        public DateTime FModificacion { get; set; }
        public DateTime FEliminado { get; set; }
        public bool Activo { get; set; }
    }
}
