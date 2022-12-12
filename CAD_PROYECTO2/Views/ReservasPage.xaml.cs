using CAD_PROYECTO2.Models;

namespace CAD_PROYECTO2.Views;

public partial class ReservasPage : ContentPage
{
	public ReservasPage()
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
			dropdownControl.DisplayName 
			);
        reservas.Loadsuarios(reserva);
        await Shell.Current.GoToAsync(nameof(Views.Reservas));



    }
}