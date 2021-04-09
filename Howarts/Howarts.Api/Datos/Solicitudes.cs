using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Howarts.Api.Datos
{
    public class Solicitud : Entity
    {

        [Required]
        [MaxLength(20)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(20)]
        public string Apellido { get; set; }
        [Required]
        [MaxLength(10)]
        public int Identificacion { get; set; }
        [Required]
        [MaxLength(2)]
        public int Edad { get; set; }
        [Required]
        public ICollection<Casas> Casas { get; set; } = new HashSet<Casas>();

    }
}
