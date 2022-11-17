using AtelierBooking.Extensions;
using AtelierBooking.Helpers;
using CommunityToolkit.Maui;
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
			.UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", Styled.BoldFont);
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
