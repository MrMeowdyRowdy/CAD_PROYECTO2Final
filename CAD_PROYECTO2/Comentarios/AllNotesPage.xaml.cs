namespace CAD_PROYECTO2.Comentarios;

public partial class AllNotesPage : ContentPage
{
    public AllNotesPage()
    {
        InitializeComponent();
        BindingContext = new Models.AllNotes();
    }

    protected override void OnAppearing()
    {
        ((Models.AllNotes)BindingContext).LoadNotes();
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var note = (Models.Note)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(ComentarioS1)}?{nameof(ComentarioS1.ItemId)}={note.Filename}");

            // Unselect the UI
            notesCollection.SelectedItem = null;
        }
    }
}
