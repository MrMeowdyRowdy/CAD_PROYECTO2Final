using CAD_PROYECTO2.Models;
using CAD_PROYECTO2.Anonimo;

namespace CAD_PROYECTO2.Views;

public partial class RegisterPage : ContentPage
{
     

    public RegisterPage()
	{
		InitializeComponent();
	}

	private  void Register_Clicked(object sender, EventArgs e)
	{
        Usuarios.Loadsuarios(new Usuario(Nombre.Text, Contraseņa.Text));
        Advertencia.Text = Nombre.Text + " " + Email.Text + " " + Contraseņa.Text;
        Shell.Current.GoToAsync(nameof(Anonimo.AMainPage));
    }
}