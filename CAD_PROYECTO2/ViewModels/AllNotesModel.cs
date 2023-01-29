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
    //NotesForSearch y demas estan en proceso de ser implementados, servicio de busqueda relativa para los comentarios
    public partial class AllNotesModel : ObservableObject
    {
        //public static List<Note> NotesForSearch { get; private set; } = new List<Note>();

        //Creacion de la lista observable para mostrar los comentarios
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();
        //uso de la interfaz con la BDD
        private readonly InterfazBDD _noteService;
        //Declaracion de el uso de la interfaz
        public AllNotesModel(InterfazBDD noteService)
        {
            _noteService = noteService;
        }

        //Declaracion para el uso de GetNote para conseguir y añadir las notas en una lista y el uso de este como comando para 
        //ser usado en .xaml
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
                    if(note.serv == 1)
                    Notes.Add(note);
                }
                //NotesForSearch.Clear();
                //NotesForSearch.AddRange(noteList);
            }
        }

        //Se crea un comando para ser implementado en el .xaml que llevara a la pestaña de creacion o actualizacion de la nota
        [ICommand]
        public async void AddUpdateNote()
        {
            await AppShell.Current.GoToAsync(nameof(ComentarioS1));
        }

        //definicion del comando mostrar para desplegar acciones en las notas una vez que sean tapeadas o clickeadas
        [ICommand]
        public async void MostrarAccion(Note noteModel)
        {
            //implementacion de un menu pop up con opciones 
            var response = await AppShell.Current.DisplayActionSheet("Seleccione Opcion", "OK", null, "Editar", "Borrar");
            if (response == "Editar")
            {
                //comparticion de los detalles de las notas en caso de una edicion
                var navParam = new Dictionary<string, object>
                {
                    { "NoteDetail", noteModel }
                };
                await AppShell.Current.GoToAsync(nameof(ComentarioS1), navParam);
            }

            //definicion de la eliminacion de una nota y actualizacion de la pantalla
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
