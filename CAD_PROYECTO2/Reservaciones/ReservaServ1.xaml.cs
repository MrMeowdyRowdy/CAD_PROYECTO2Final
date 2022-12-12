using CAD_PROYECTO2.Models;

namespace CAD_PROYECTO2.Reservaciones;

public partial class ReservaServ1 : ContentPage
{
	public ReservaServ1()
	{
        InitializeComponent();

        var Items = new List<Items>();

        Items.Add(new Items { Titulo = "Servicio 1" });
        Items.Add(new Items { Titulo = "Servicio 2" });
        Items.Add(new Items { Titulo = "Servicio 3" });

        dropdownControl.ItemSource = Items;
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        Reserva reserva = new Reserva(
            Nombre.Text,
            Apellido.Text,
            "Servicio 1"
            );
        reservas.Loadsuarios(reserva);
        await Shell.Current.GoToAsync(nameof(Views.Reservas));



    }
}