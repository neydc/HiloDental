using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyDentoWeb.Models;

namespace ProyDentoWeb.BD.Maps
{
    public class CitaMap : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder)
        {
            builder.ToTable("Cita");
            builder.HasKey(o => o.idCita);

            builder.HasOne(o => o.cliente).WithMany(o => o.citas).HasForeignKey(o => o.idCliente);

            builder.HasOne(o => o.doctor).WithMany(o => o.citas).HasForeignKey(o => o.idDoctor);

            builder.HasOne(o => o.horario).WithMany().HasForeignKey(o => o.idHorario);

            builder.HasOne(o => o.Historial).WithMany().HasForeignKey(o => o.idCita);
        
        }
    }
}