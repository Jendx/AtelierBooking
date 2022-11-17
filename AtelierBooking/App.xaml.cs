using AtelierBooking.Pages;

namespace AtelierBooking;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new BookingListPage());
		MainPage.Navigation.PushAsync(new BookingListPage());
    }
}
