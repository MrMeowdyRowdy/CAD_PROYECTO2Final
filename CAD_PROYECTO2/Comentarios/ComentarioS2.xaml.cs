namespace CAD_PROYECTO2.Comentarios;
[QueryProperty(nameof(ItemId), nameof(ItemId))]

public partial class ComentarioS2 : ContentPage
{
    public string ItemId
    {
        set { LoadNote2(value); }
    }

    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes2.txt");

    public ComentarioS2()
    {
        InitializeComponent();
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes2.txt";

        LoadNote2(Path.Combine(appDataPath, randomFileName));
    }
    private async void SaveButton2_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        if (BindingContext is Models.Note note)
            File.WriteAllText(note.Filename, TextEditor.Text);
        await Shell.Current.GoToAsync(nameof(Comentarios.AllNotesPage2));
    }
    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Note note)
        {
            if (File.Exists(note.Filename))
                File.Delete(note.Filename);
        }

        await Shell.Current.GoToAsync(nameof(Comentarios.AllNotesPage2));
    }
    private void LoadNote2(string fileName)
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
        await Shell.Current.GoToAsync(nameof(CDServicios.Servicio2));
    }
}