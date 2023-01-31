using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.Models
{
    [Table("Note")]

    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int IdComentario { get; set; }

        public string Filename { get; set; }
        public string Text { get; set; }
        public string Titulo { get; set; }
        public DateTime Date { get; set; }
        public int serv { get; set; }
    }
}