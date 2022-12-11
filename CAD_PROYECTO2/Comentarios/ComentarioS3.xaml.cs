namespace CAD_PROYECTO2.Comentarios;

[QueryProperty(nameof(ItemId), nameof(ItemId))]

public partial class ComentarioS3 : ContentPage
{
    public string ItemId
    {
        set { LoadNote3(value); }
    }

    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes3.txt");

    public ComentarioS3()
    {
        InitializeComponent();
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes3.txt";

        LoadNote3(Path.Combine(appDataPath, randomFileName));
    }
    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        if (BindingContext is Models.Note note)
            File.WriteAllText(note.Filename, TextEditor.Text);
        await Shell.Current.GoToAsync(nameof(Comentarios.AllNotesPage3));
    }

    private void LoadNote3(string fileName)
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
        await Shell.Current.GoToAsync(nameof(CDServicios.Servicio3));
    }
}