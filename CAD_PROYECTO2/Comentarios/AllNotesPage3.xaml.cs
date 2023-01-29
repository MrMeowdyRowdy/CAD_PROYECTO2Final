using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Comentarios;

public partial class AllNotesPage3 : ContentPage
{
    private AllNotesModel3 viewMode;
    public AllNotesPage3(AllNotesModel3 viewModel)
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