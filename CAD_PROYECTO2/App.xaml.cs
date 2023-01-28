using CAD_PROYECTO2.DataBase;
using CAD_PROYECTO2.Models;
using CAD_PROYECTO2.Views;

namespace CAD_PROYECTO2;

public partial class App : Application
{
	public static Usuario DetalleUsuarios;
    public static CadDataBase BaseRepo { get; set; }
    public App(CadDataBase repo)
	{	
		InitializeComponent();

		MainPage = new AppShell();
        BaseRepo = repo;
    }
}
