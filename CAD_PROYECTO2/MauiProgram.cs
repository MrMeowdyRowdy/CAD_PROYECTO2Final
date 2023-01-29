using CAD_PROYECTO2.Comentarios;
using CAD_PROYECTO2.Models;
using CAD_PROYECTO2.Services;
using CAD_PROYECTO2.ViewModels;
using CAD_PROYECTO2.Views;

namespace CAD_PROYECTO2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<InterfazBDD, BDComentarios>();

        builder.Services.AddSingleton<AllNotesPage>();
        builder.Services.AddSingleton<AllNotesPage2>();
        builder.Services.AddSingleton<AllNotesPage3>();

        builder.Services.AddTransient<ComentarioS1>();
        builder.Services.AddTransient<ComentarioS2>();
        builder.Services.AddTransient<ComentarioS3>();

        builder.Services.AddSingleton<AllNotesModel>();
        builder.Services.AddSingleton<AllNotesModel2>();
        builder.Services.AddSingleton<AllNotesModel3>();

        builder.Services.AddTransient<AddUpdateNotesModel>();
        builder.Services.AddTransient<AddUpdateNotesModel2>();
        builder.Services.AddTransient<AddUpdateNotesModel3>();

        return builder.Build();
    }

}
