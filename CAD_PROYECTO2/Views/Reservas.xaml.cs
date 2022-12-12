using CAD_PROYECTO2.Models;

namespace CAD_PROYECTO2.Views;

public partial class Reservas : ContentPage
{
	public Reservas()
	{
		InitializeComponent();
		reserva.Text = reservas.Reservas();

    }
}