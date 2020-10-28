using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyDentoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyDentoWeb.BD.Maps
{
    public class HistorialMap : IEntityTypeConfiguration<Historial>
    {
        public void Configure(EntityTypeBuilder<Historial> builder)
        {
            builder.ToTable("Historial");
            builder.HasKey(o => o.idHistorial);

            builder.HasOne(o => o.doctor).WithMany().HasForeignKey(o => o.idDoctor);
            builder.HasOne(o => o.cliente).WithMany().HasForeignKey(o => o.idCliente);
       
         builder.HasMany(o => o.Cita).WithOne().HasForeignKey(o => o.idHistorial);
       
        
        }
    }
}
