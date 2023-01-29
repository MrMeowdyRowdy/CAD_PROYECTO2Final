using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Reservaciones;

public partial class AllReservasPage2 : ContentPage
{
    private AllReservasModel2 viewMode;
    public AllReservasPage2(AllReservasModel2 viewModel)
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