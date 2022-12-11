using CAD_PROYECTO2.Models;
using Microsoft.Maui.Controls;

namespace CAD_PROYECTO2.Views;

public partial class Servicios : ContentPage
{
	public Servicios()
	{
		InitializeComponent();
		
	}
	
	private async void SeeMore_Clicked(object sender, EventArgs e)
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