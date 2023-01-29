namespace CAD_PROYECTO2.CDServicios;

public partial class Servicio1 : ContentPage
{
	public Servicio1()
	{
		InitializeComponent();
      
    }

	private async void Volver_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Comentarios.AllNotesPage));
    }

	private async void ReservacionesClick(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Reservaciones.ReservaServ1));
    }
}