using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD_PROYECTO2.Models;

namespace CAD_PROYECTO2.Services
{
    public class BDComentarios : InterfazBDD
    {
        private SQLiteAsyncConnection conn;

        private async Task ReadySteadyGO()
        {
            if (conn == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "comentarios.db3");
                conn = new SQLiteAsyncConnection(dbPath);
                await conn.CreateTableAsync<Note>();
                //await conn.CreateTableAsync<Reserva>();
            }
        }

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
    }
}
