

using Microsoft.EntityFrameworkCore;
using ProyDentoWeb.BD.Maps;
using ProyDentoWeb.Models;

namespace ProyDentoWeb.BD
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Historial> Historials{ get; set; }
        public AppDBContext( DbContextOptions<AppDBContext> options) : base (options)    {        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Esto se hace por cada tabla de base de datos
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new HorarioMap());
            modelBuilder.ApplyConfiguration(new DoctorMap());
            modelBuilder.ApplyConfiguration(new CitaMap());
            modelBuilder.ApplyConfiguration(new HistorialMap());
        }

    }
    
}
