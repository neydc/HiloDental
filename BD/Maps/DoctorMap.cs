using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyDentoWeb.Models;

namespace ProyDentoWeb.BD.Maps
{
    public class DoctorMap : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctor");
            builder.HasKey(o => o.idDoctor);

            builder.HasMany(o => o.citas).WithOne(o => o.doctor).HasForeignKey(o => o.idDoctor);
        }
    }
}