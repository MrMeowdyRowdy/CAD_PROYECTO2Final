using CAD_PROYECTO2.Models;
using CAD_PROYECTO2.Views;

namespace CAD_PROYECTO2;

public partial class App : Application
{
	public static Usuario DetalleUsuarios;
	public App()
	{	
		InitializeComponent();

		MainPage = new AppShell();
		
	}
}
