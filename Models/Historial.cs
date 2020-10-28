using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyDentoWeb.Models
{
    public class Historial
    {
        public int idHistorial { get; set; }
        public int idCita { get; set; }
        public int numeroHistoria { get; set; }
        public string observacion { get; set; }
        public string motivo { get; set; }
        public DateTime fecha { get; set; }
        public int edad { get; set; }
        public string descripcion { get; set; }
        public string examenes { get; set; }
        public string diagnostico { get; set; }
        public string tratamiento { get; set; }
        public int idDoctor { get; set; }
        public int idCliente { get; set; }
        public List <Cita> Cita { get; set; }
        public Doctor doctor { get; set; }
        public Cliente cliente { get; set; }
    }
}
