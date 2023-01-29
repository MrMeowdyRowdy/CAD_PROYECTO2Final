using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD_PROYECTO2.Models;

namespace CAD_PROYECTO2.Services
{
    public class BDLocalCAD : InterfazBDD
    {
        //se declara el uso de una conexion asincrona con la BDD
        private SQLiteAsyncConnection conn;

        //inicializacion de la base de datos y creacion de la misma ademas de establecer el Path a esta
        private async Task ReadySteadyGO()
        {
            if (conn == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "comentarios.db3");
                conn = new SQLiteAsyncConnection(dbPath);
                await conn.CreateTableAsync<Note>();
                await conn.CreateTableAsync<Reserva>();
            }
        }

        //Codigo para interaccion de la BDD con la tabla comentarios
        public async Task<int> AddCommentCAD(Note comment)
        {
            await ReadySteadyGO();
            return await conn.InsertAsync(comment);
        }

        public async Task<int> DeleteCommentCAD(Note comment)
        {
            await ReadySteadyGO();
            return await conn.DeleteAsync(comment);
        }

        public async Task<List<Note>> GetCommentListCAD()
        {
            await ReadySteadyGO();
            var commentList = await conn.Table<Note>().ToListAsync();
            return commentList;
        }

        public async Task<int> UpdateCommentCAD(Note comment)
        {
            await ReadySteadyGO();
            return await conn.UpdateAsync(comment);
        }

        //Codigo para la interaccion de la BDD con la tabla de Reservas
        public async Task<int> AddReservaCAD(Reserva reserva)
        {
            await ReadySteadyGO();
            return await conn.InsertAsync(reserva);
        }

        public async Task<int> DeleteReservaCAD(Reserva reserva)
        {
            await ReadySteadyGO();
            return await conn.DeleteAsync(reserva);
        }

        public async Task<List<Reserva>> GetReservaListCAD()
        {
            await ReadySteadyGO();
            var reservaList = await conn.Table<Reserva>().ToListAsync();
            return reservaList;
        }

        public async Task<int> UpdateReservaCAD(Reserva reserva)
        {
            await ReadySteadyGO();
            return await conn.UpdateAsync(reserva);
        }
    }
}
