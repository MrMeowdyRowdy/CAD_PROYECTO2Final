using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Reservaciones;

public partial class AllReservasPage3 : ContentPage
{
    private AllReservasModel3 viewMode;
    public AllReservasPage3(AllReservasModel3 viewModel)
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