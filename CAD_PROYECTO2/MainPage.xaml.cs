namespace CAD_PROYECTO2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void SeeMore1_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(CDServicios.Servicio1));
    }

	private async void SeeMore2_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(CDServicios.Servicio2));
    }

	private async void SeeMore3_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(CDServicios.Servicio3));
    }

}

