using CAD_PROYECTO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.Services
{
    public interface InterfazBDD
    {
        //Se establece las interfaces para los metodos de la base de datos para Comentarios
        Task<List<Note>> GetCommentListCAD();
        Task<int> AddCommentCAD(Note comentario);
        Task<int> DeleteCommentCAD(Note comentario);
        Task<int> UpdateCommentCAD(Note comentario);

        //Se establece las interfaces para los metodos de la base de datos para Reservas
        Task<List<Reserva>> GetReservaListCAD();
        Task<int> AddReservaCAD(Reserva reserva);
        Task<int> DeleteReservaCAD(Reserva reserva);
        Task<int> UpdateReservaCAD(Reserva reserva);
    }
}
