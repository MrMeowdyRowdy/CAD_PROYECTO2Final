namespace CAD_PROYECTO2.Anonimo;

public partial class AMainPage : ContentPage
{
	

	public AMainPage()
	{
		InitializeComponent();
	}

	private async void SeeMore1_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Anonimo.AServicio1));
    }

	private async void SeeMore2_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Anonimo.AServicio2));
    }

	private async void SeeMore3_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Anonimo.AServicio3));
    }

	private async void Add_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Views.LoginPage));
    }
}

