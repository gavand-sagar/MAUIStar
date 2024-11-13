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
            })
//            .ConfigureMauiHandlers(handlers =>
//            {
//#if WINDOWS
//                handlers.AddHandler<Entry, CustomeEntryHandler>();
//#endif
//            })
            ;

        builder.Services.AddSingleton<AppShell>();

        builder.Services.AddTransient<ProductListPageViewModel>();
        builder.Services.AddTransient<PhotosListViewModel>();
        builder.Services.AddTransient<DependencyDemoPageViewModel>();
        builder.Services.AddTransient<LoginPageViewModel>();

        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<IMyStorageService, MyStorageService>();


#if ANDROID
                builder.Services.AddSingleton<IDialogService, AndroidDialogService>();
#else
        builder.Services.AddSingleton<IDialogService, DialogService>();
#endif

        var app = builder.Build();
        ViewModelLocator.App = app;
        return app;
    }
}
