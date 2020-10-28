using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyDentoWeb.Models;

namespace ProyDentoWeb.BD.Maps
{
    public class UserMap : IEntityTypeConfiguration <User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(o => o.idUsuario);
        }
    }
}
