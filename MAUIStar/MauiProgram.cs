using MAUIStar.ViewModels;
using MAUIStar.Services;

namespace MAUIStar;

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

		builder.Services.AddSingleton<AppShell>();
		
		builder.Services.AddTransient<ProductListPageViewModel>();
		builder.Services.AddTransient<PhotosListViewModel>();


		builder.Services.AddSingleton<IDialogService, DialogService>();

		var app = builder.Build();
        ViewModelLocator.App = app;
        return app;
	}
}
