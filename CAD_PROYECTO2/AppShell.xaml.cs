using CAD_PROYECTO2.Anonimo;
using CAD_PROYECTO2.CDServicios;
using CAD_PROYECTO2.Comentarios;
using CAD_PROYECTO2.Models;
using CAD_PROYECTO2.Reservaciones;
using CAD_PROYECTO2.Views;

namespace CAD_PROYECTO2;

public partial class AppShell : Shell
{
    
    public AppShell()
	{

		InitializeComponent();

        Routing.RegisterRoute(nameof(Views.Servicios), typeof(Servicios));
        

        Routing.RegisterRoute(nameof(Comentarios.ComentarioS1), typeof(ComentarioS1));
        Routing.RegisterRoute(nameof(Comentarios.ComentarioS2), typeof(ComentarioS2));
        Routing.RegisterRoute(nameof(Comentarios.ComentarioS3), typeof(ComentarioS3));
        Routing.RegisterRoute(nameof(CDServicios.Servicio1), typeof(Servicio1));
        Routing.RegisterRoute(nameof(CDServicios.Servicio2), typeof(Servicio2)); 
        Routing.RegisterRoute(nameof(CDServicios.Servicio3), typeof(Servicio3));
        Routing.RegisterRoute(nameof(Comentarios.AllNotesPage), typeof(AllNotesPage));
        Routing.RegisterRoute(nameof(Comentarios.AllNotesPage2), typeof(AllNotesPage2));
        Routing.RegisterRoute(nameof(Comentarios.AllNotesPage3), typeof(AllNotesPage3));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(Views.LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(Views.RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(Views.SobreNosotros), typeof(SobreNosotros));
        Routing.RegisterRoute(nameof(Anonimo.AMainPage), typeof(AMainPage));
        Routing.RegisterRoute(nameof(Anonimo.AServicios), typeof(AServicios));
        Routing.RegisterRoute(nameof(Anonimo.AServicio1), typeof(AServicio1));
        Routing.RegisterRoute(nameof(Anonimo.AServicio2), typeof(AServicio2));
        Routing.RegisterRoute(nameof(Anonimo.AServicio3), typeof(AServicio3));
        Routing.RegisterRoute(nameof(Anonimo.ASobreNosotros), typeof(ASobreNosotros));
        Routing.RegisterRoute(nameof(Reservaciones.ReservaServ1), typeof(ReservaServ1));
        Routing.RegisterRoute(nameof(Reservaciones.ReservaServ2), typeof(ReservaServ2));
        Routing.RegisterRoute(nameof(Reservaciones.ReservaServ3), typeof(ReservaServ3));
        Routing.RegisterRoute(nameof(Views.Reservas), typeof(Reservas));
        Routing.RegisterRoute(nameof(Reservaciones.AllReservasPage), typeof(AllReservasPage));
        Routing.RegisterRoute(nameof(Reservaciones.AllReservasPage2), typeof(AllReservasPage2));
        Routing.RegisterRoute(nameof(Reservaciones.AllReservasPage3), typeof(AllReservasPage3));
    }

    private async void Out_Button(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Anonimo.AMainPage));
    }
}
