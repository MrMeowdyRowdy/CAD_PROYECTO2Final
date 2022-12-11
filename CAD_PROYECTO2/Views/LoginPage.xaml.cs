using CAD_PROYECTO2.Models;


namespace CAD_PROYECTO2.Views;

public partial class LoginPage : ContentPage
{
    
    
    public LoginPage ()
	{
		InitializeComponent();
        Usuarios.Loadsuarios(new Usuario("Pablo", "12345"));
        Usuarios.Loadsuarios(new Usuario("Gabo", "123"));

    }

	private void LoginButton_Clicked(object sender, EventArgs e)
	{
        if(Usuarios.SearchUsers(new Usuario(Nombre.Text, Contraseña.Text))==true)
        {
            Shell.Current.GoToAsync(nameof(MainPage));
        }
        else
        {
            Advertencia.Text = "Usuario no Registrado o Credenciales Incorrectas";
        }
            
       
    }

    private void Registro_Button(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Views.RegisterPage));
    }
}