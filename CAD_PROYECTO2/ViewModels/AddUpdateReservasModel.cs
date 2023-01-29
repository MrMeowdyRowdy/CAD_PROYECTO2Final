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
    [QueryProperty(nameof(ReservaDetail), "ReservaDetail")]
    public partial class AddUpdateReservaModel : ObservableObject
    {
        [ObservableProperty]
        private Reserva _ReservaDetail = new Reserva();

        private readonly InterfazBDD reservaService;
        public AddUpdateReservaModel(InterfazBDD reserva)
        {
            this.reservaService = reserva;
        }

        [ICommand]
        public async void AddUpdateReserva()
        {
            int response = -1;
            if (ReservaDetail.IdReserva > 0)
            {
                response = await reservaService.UpdateReservaCAD(ReservaDetail);
            }
            else
            {
                response = await reservaService.AddReservaCAD(new Models.Reserva
                {
                    Nombre = ReservaDetail.Nombre,
                    Apellido = ReservaDetail.Apellido,
                    servicio = "Servicio 1",
                    //fecha = ReservaDetail.fecha,
                }); 
            }

            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Reserva realizada", "Registro guardado exitosamente", "OK");
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
