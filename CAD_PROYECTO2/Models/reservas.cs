using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.Models
{
    public  static class reservas
    {

        public static List<Reserva> Res = new List<Reserva>();
        public static void Loadsuarios(Reserva reserva) => Res.Add(reserva);

        public static string Reservas()
        {
            string reser = "";
            foreach(var reserva in Res)
            {
                reser += "Nombre: "+reserva.Nombre+" Apellido: "+reserva.Apellido+ " Servicio: "+reserva.servicio+ "\n";
            }
            return reser;
        }
    }
}
