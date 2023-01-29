using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Comentarios;

public partial class ComentarioS3 : ContentPage
{
    public ComentarioS3(AddUpdateNotesModel3 viewmodel)
    {
        InitializeComponent();
        this.BindingContext = viewmodel;
    }
}