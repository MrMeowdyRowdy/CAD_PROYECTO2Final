using CAD_PROYECTO2.Anonimo;
using Microsoft.Maui.Controls;

namespace CAD_PROYECTO2.Anonimo;

public partial class AServicios : ContentPage
{
	public AServicios()
	{
		InitializeComponent();
		
	}
	
	private async void SeeMore_Clicked(object sender, EventArgs e)
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
}