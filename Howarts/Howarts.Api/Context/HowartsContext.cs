using Howarts.Api.Context.Inicio;
using Howarts.Api.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howarts.Api.Context
{
    public class HowartsContext : DbContext
    {
        public HowartsContext(DbContextOptions<HowartsContext> options)
            : base(options)
        {

        }

        public DbSet<Casas> Casas { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CasasSeeder());
        }
    }
}
