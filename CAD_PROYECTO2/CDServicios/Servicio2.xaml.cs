namespace CAD_PROYECTO2.CDServicios;

public partial class Servicio2 : ContentPage
{
	public Servicio2()
	{
		InitializeComponent();
	}

    private async void Volver_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Comentarios.AllNotesPage2));
    }

    private async void ReservacionesClick(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Reservaciones.AllReservasPage2));
    }
}