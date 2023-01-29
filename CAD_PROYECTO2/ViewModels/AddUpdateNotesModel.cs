using CAD_PROYECTO2.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using CAD_PROYECTO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.ViewModels
{
    [QueryProperty(nameof(NoteDetail), "NoteDetail")]
    public partial class AddUpdateNotesModel : ObservableObject
    {
        [ObservableProperty]
        private Note _NoteDetail = new Note();

        private readonly InterfazBDD noteService;
        public AddUpdateNotesModel(InterfazBDD noteService)
        {
            this.noteService = noteService;
        }

        [ICommand]
        public async void AddUpdateNote()
        {
            int response = -1;
            if (NoteDetail.IdComentario > 0)
            {
                response = await noteService.UpdateCommentCAD(NoteDetail);
            }
            else
            {
                response = await noteService.AddCommentCAD(new Models.Note
                {
                    Titulo = NoteDetail.Titulo,
                    Text = NoteDetail.Text,
                    serv = 1,
                });
            }

            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Comentario Guardado", "Registro guardado exitosamente", "OK");
                await Shell.Current.GoToAsync("..");
            }
            else
            {
                await Shell.Current.DisplayAlert("ERROR", "Algo fallo mientras se guardaba el registro", "OK");
                await Shell.Current.GoToAsync("..");
            }
        }
    }
}
