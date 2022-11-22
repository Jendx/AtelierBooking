namespace AtelierBooking.ViewModels;

using AtelierBooking.Http;
using AtelierBooking.Models;
using AtelierBooking.Models.CommandParameters;
using AtelierBooking.Pages.Popups;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

internal sealed class BookingListViewModel
{
    private INavigation _navigation;
    private ApiClient _apiClient;

    public BookingListViewModel(ApiClient apiClient)
    {
        _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
    }

    public ICommand RejectCommand { get; private set; }

    public ICommand ApproveCommand { get; private set; }

    public List<BookTime> BookTimes { get; private set; }

    public async Task InitAsync(INavigation navigation)
    {
        //BookTimes = new();
        //BookTimes.Add(new BookTime() { FirstName = "Pepa", LastName = "Kokos", Contact = "792759877", BookedFrom = TimeOnly.MinValue, BookedTo = TimeOnly.MaxValue, Date = DateOnly.MaxValue });
        //BookTimes.Add(new BookTime() { FirstName = "Evžen" });



        _navigation = navigation;
        RejectCommand = new Command<ApproveRejectParameters>((parameters) =>
        {
            _navigation.NavigationStack.Last().ShowPopup(new RejectPopup(parameters));
        });

        ApproveCommand = new Command(() =>
        {
            // SQL Update
        });
    }

    private async Task LoadData()
    {
        BookTimes = await _apiClient.GetBookTimes();
    }
}
