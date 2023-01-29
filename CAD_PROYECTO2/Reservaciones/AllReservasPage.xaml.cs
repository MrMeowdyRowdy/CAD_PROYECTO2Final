using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Reservaciones;

public partial class AllReservasPage : ContentPage
{
    private AllReservasModel viewMode;
    public AllReservasPage(AllReservasModel viewModel)
    {
        InitializeComponent();
        viewMode = viewModel;
        this.BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewMode.GetReservaListCommand.Execute(null);
    }
}