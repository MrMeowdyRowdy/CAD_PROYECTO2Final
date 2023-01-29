using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Comentarios;

public partial class AllNotesPage : ContentPage
{
    private AllNotesModel viewMode;
    public AllNotesPage(AllNotesModel viewModel)
    {
        InitializeComponent();
        viewMode = viewModel;
        this.BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewMode.GetNoteListCommand.Execute(null);
    }
}
