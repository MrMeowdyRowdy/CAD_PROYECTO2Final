using CAD_PROYECTO2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.DataBase
{
    public class CadDataBase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public CadDataBase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Note>();
            conn.CreateTable<Reserva>();
        }
        public int AddNewNote (Note Note)
        {
            Init();
            if (Note.Id != 0)
            {
                return conn.Update(Note);
            }
            else
            {
                return conn.Insert(Note);
            }
        }

        public int AddNewReserva(Reserva Reserva)
        {
            Init();
            if (Reserva.Id != 0)
            {
                return conn.Update(Reserva);
            }
            else
            {
                return conn.Insert(Reserva);
            }
        }

        public List<Note> GetAllNotes()
        {
            Init();
            List<Note> burgers = conn.Table<Note>().ToList();
            return burgers;
        }

        public List<Reserva> GetAllReservas()
        {
            Init();
            List<Reserva> Reservas = conn.Table<Reserva>().ToList();
            return Reservas;
        }

        public int DeleteItemNote(Note item)
        {
            Init();
            return conn.Delete(item);
        }

        public int DeleteItemReserva(Reserva item)
        {
            Init();
            return conn.Delete(item);
        }
    }
}
