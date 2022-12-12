namespace CAD_PROYECTO2.CDServicios;

public partial class Servicio3 : ContentPage
{
	public Servicio3()
	{
		InitializeComponent();
	}
    private async void Comentarios3_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Comentarios.ComentarioS3));
    }

    private async void Volver_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Comentarios.AllNotesPage3));
    }
}