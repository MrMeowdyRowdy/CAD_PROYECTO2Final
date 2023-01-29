using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.Models
{
    [Table("Reservas")]
    public class Reserva
    { 
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String servicio { get; set; }

        public Reserva(string nombre, string Apellido , string servicio)
        {
            this.Nombre = nombre;
            this.Apellido = Apellido;   
            this.servicio = servicio;
        }

    }
}
