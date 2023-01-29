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
using CAD_PROYECTO2.Reservaciones;

namespace CAD_PROYECTO2.ViewModels
{
    //NotesForSearch y demas estan en proceso de ser implementados, servicio de busqueda relativa para los reservas
    public partial class AllReservasModel2 : ObservableObject
    {
        //public static List<Note> ReservasForSearch { get; private set; } = new List<Note>();

        //Creacion de la lista observable para mostrar los resevas
        public ObservableCollection<Reserva> Reservas { get; set; } = new ObservableCollection<Reserva>();
        //uso de la interfaz con la BDD
        private readonly InterfazBDD _reservaService;
        //Declaracion de el uso de la interfaz
        public AllReservasModel2(InterfazBDD reservaService)
        {
            _reservaService = reservaService;
        }

        //Declaracion para el uso de GetReserva para conseguir y añadir las reservas en una lista y el uso de este como comando para 
        //ser usado en .xaml
        [ICommand]
        public async void GetReservaList()
        {
            Reservas.Clear();
            var reservaList = await _reservaService.GetReservaListCAD();
            if (reservaList?.Count > 0)
            {
                reservaList = reservaList.OrderBy(f => f.Apellido).ToList();
                foreach (var reserva in reservaList)
                {
                    if(reserva.servicio.Equals("Servicio 2"))
                    Reservas.Add(reserva);
                }
            }
        }

        //Se crea un comando para ser implementado en el .xaml que llevara a la pestaña de creacion o actualizacion de la reserva
        [ICommand]
        public async void AddUpdateReserva()
        {
            await AppShell.Current.GoToAsync(nameof(ReservaServ2));
        }

        //definicion del comando mostrar para desplegar acciones en las reservas una vez que sean tapeadas o clickeadas
        [ICommand]
        public async void MostrarAccion(Reserva reservaModel)
        {
            //implementacion de un menu pop up con opciones 
            var response = await AppShell.Current.DisplayActionSheet("Seleccione Opcion", "OK", null, "Editar", "Borrar");
            if (response == "Editar")
            {
                //comparticion de los detalles de las reservas en caso de una edicion
                var navParam = new Dictionary<string, object>
                {
                    { "ReservaDetail", reservaModel }
                };
                await AppShell.Current.GoToAsync(nameof(ReservaServ2), navParam);
            }

            //definicion de la eliminacion de una reserva y actualizacion de la pantalla
            else if (response == "Borrar")
            {
                var delResponse = await _reservaService.DeleteReservaCAD(reservaModel);
                if (delResponse > 0)
                {
                    GetReservaList();
                }
            }
        }
    }
}
