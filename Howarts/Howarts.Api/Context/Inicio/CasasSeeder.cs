using Howarts.Api.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howarts.Api.Context.Inicio
{
    internal class CasasSeeder : IEntityTypeConfiguration<Casas>
    {
        public void Configure(EntityTypeBuilder<Casas> builder)
        {
            builder.HasData(
                  new Casas
                  {
                      Id = 1,
                      Nombre = "Gryffindor"
                  },
                  new Casas
                  {
                      Id = 2,
                      Nombre = "Hufflepuff"
                  },
                  new Casas
                  {
                      Id = 3,
                      Nombre = "Ravenclaw"
                  },
                     new Casas
                     {
                         Id = 4,
                         Nombre = "Slytherin"
                     }

                );
        }
    }
}
