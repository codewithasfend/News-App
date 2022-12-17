using Microsoft.Extensions.Logging;
using NewsApp.Services;
using NewsApp.ViewModel;
using NewsApp.View;
namespace NewsApp;

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

		builder.Services.AddSingleton<NewsService>();
		builder.Services.AddSingleton<NewsViewModel>();
		builder.Services.AddSingleton<NewsPage>();
		builder.Services.AddSingleton<NewsDetailPage>();
        builder.Services.AddSingleton<NewsDetailViewModel>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

