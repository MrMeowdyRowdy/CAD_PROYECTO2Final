﻿namespace CAD_PROYECTO2.Anonimo;

public partial class AMainPage : ContentPage
{
	

	public AMainPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Anonimo.ASobreNosotros));
    }



    private async void servicios_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Anonimo.AServicios));
    }

    private async void Add_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Views.LoginPage));
    }

    private void Registro_Button(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Views.RegisterPage));
    }
}

