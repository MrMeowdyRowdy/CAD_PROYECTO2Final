using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Reservaciones;

public partial class ReservaServ3 : ContentPage
{
    public ReservaServ3(AddUpdateReservaModel3 viewmodel)
    {
        InitializeComponent();
        this.BindingContext = viewmodel;
    }
}