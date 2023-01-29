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
        Task<List<Note>> GetCommentListCAD();
        Task<int> AddCommentCAD(Note comentario);
        Task<int> DeleteCommentCAD(Note comentario);
        Task<int> UpdateCommentCAD(Note comentario);
    }
}
