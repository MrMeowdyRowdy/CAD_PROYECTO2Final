using CAD_PROYECTO2.ViewModels;

namespace CAD_PROYECTO2.Comentarios;

public partial class ComentarioS1 : ContentPage
{ 
	public ComentarioS1(AddUpdateNotesModel viewmodel)
	{
		InitializeComponent();
		this.BindingContext = viewmodel;
    }

}