
using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Comentarios;

public partial class AllNotesPage2 : ContentPage
{
    private AllNotesModel2 viewMode;
    public AllNotesPage2(AllNotesModel2 viewModel)
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