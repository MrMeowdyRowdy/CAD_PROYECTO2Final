using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Comentarios;

public partial class ComentarioS2 : ContentPage
{
    public ComentarioS2(AddUpdateNotesModel2 viewmodel)
    {
        InitializeComponent();
        this.BindingContext = viewmodel;
    }
}