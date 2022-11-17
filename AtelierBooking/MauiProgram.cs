using AtelierBooking.Extensions;
using CommunityToolkit.Maui.Markup;

namespace AtelierBooking;

public static class MauiProgram
{
	internal static IServiceProvider ServiceProvider { get; private set; }

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		var services = builder.RegisterServices();
		ServiceProvider = services.BuildServiceProvider();

		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
