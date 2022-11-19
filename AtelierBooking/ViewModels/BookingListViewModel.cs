namespace AtelierBooking.ViewModels;

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
    
    public ICommand RejectCommand { get; private set; }

    public ICommand ApproveCommand { get; private set; }

    public List<BookTime> BookTimes { get; private set; }

    public async Task InitAsync(INavigation navigation)
    {
        BookTimes = new();
        BookTimes.Add(new BookTime() { FirstName = "Pepa", LastName = "Kokos", Contact = "792759877", BookedFrom = TimeOnly.MinValue, BookedTo = TimeOnly.MaxValue, Date = DateOnly.MaxValue });
        BookTimes.Add(new BookTime() { FirstName = "Evžen" });

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
}
