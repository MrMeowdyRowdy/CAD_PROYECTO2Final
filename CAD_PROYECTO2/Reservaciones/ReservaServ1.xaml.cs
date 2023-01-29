using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Reservaciones;

public partial class ReservaServ1 : ContentPage
{
	public ReservaServ1(AddUpdateReservaModel viewmodel)
	{
        InitializeComponent();
        this.BindingContext = viewmodel;
    }
}