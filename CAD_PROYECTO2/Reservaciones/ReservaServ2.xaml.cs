
using CAD_PROYECTO2.ViewModels;


namespace CAD_PROYECTO2.Reservaciones;

public partial class ReservaServ2 : ContentPage
{
    public ReservaServ2(AddUpdateReservaModel2 viewmodel)
    {
        InitializeComponent();
        this.BindingContext = viewmodel;
    }
}