
namespace CAD_PROYECTO2.Comentarios;
[QueryProperty(nameof(ItemId), nameof(ItemId))]

public partial class ComentarioS1 : ContentPage
{ 
    public string ItemId
{
    set { LoadNote(value); }
}

string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

	public ComentarioS1()
	{
		InitializeComponent();
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));
    }
    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        if (BindingContext is Models.Note note)
            File.WriteAllText(note.Filename, TextEditor.Text);
         await Shell.Current.GoToAsync(nameof(Comentarios.AllNotesPage));
    }

    private async void DeleteButton_Clicked(object sender,EventArgs e)
    {
        if (BindingContext is Models.Note note)
        {
            if (File.Exists(note.Filename))
                File.Delete(note.Filename);
        }
          
        await Shell.Current.GoToAsync(nameof(Comentarios.AllNotesPage));
    }
    private void LoadNote(string fileName)
    {
        Models.Note noteModel = new Models.Note();
        noteModel.Filename = fileName;

        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = noteModel;
    }

    private async void Volver_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CDServicios.Servicio1));
    }
}