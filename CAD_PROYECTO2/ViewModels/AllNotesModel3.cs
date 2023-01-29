using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using CAD_PROYECTO2.Models;
using CAD_PROYECTO2.Services;
using CAD_PROYECTO2.Comentarios;

namespace CAD_PROYECTO2.ViewModels
{
    public partial class AllNotesModel3 : ObservableObject
    {
        //public static List<Note> NotesForSearch { get; private set; } = new List<Note>();
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        private readonly InterfazBDD _noteService;
        public AllNotesModel3(InterfazBDD noteService)
        {
            _noteService = noteService;
        }

        [ICommand]
        public async void GetNoteList()
        {
            Notes.Clear();
            var noteList = await _noteService.GetCommentListCAD();
            if (noteList?.Count > 0)
            {
                noteList = noteList.OrderBy(f => f.Titulo).ToList();
                foreach (var note in noteList)
                {
                    if(note.serv == 3)
                    Notes.Add(note);
                }
                //NotesForSearch.Clear();
                //NotesForSearch.AddRange(noteList);
            }
        }

        [ICommand]
        public async void AddUpdateNote()
        {
            await AppShell.Current.GoToAsync(nameof(ComentarioS3));
        }

        [ICommand]
        public async void MostrarAccion(Note noteModel)
        {
            var response = await AppShell.Current.DisplayActionSheet("Seleccione Opcion", "OK", null, "Editar", "Borrar");
            if (response == "Editar")
            {
                var navParam = new Dictionary<string, object>
                {
                    { "NoteDetail", noteModel }
                };
                await AppShell.Current.GoToAsync(nameof(ComentarioS3), navParam);
            }
            else if (response == "Borrar")
            {
                var delResponse = await _noteService.DeleteCommentCAD(noteModel);
                if (delResponse > 0)
                {
                    GetNoteList();
                }
            }
        }
    }
}
