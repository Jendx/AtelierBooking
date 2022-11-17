namespace AtelierBooking.ViewModels;

using AtelierBooking.Pages.Popups;
using AtelierBooking.ViewModels.Abstraction;
using CommunityToolkit.Maui.Views;
using System.Threading.Tasks;
using System.Windows.Input;

internal sealed class BookingListViewModel : IBaseViewModel
{
    private readonly INavigation _navigation;
    
    public ICommand RejectCommand { get; private set; }

    public ICommand ApproveCommand { get; private set; }

    public BookingListViewModel(INavigation navigation)
    {
        _navigation = navigation ?? throw new ArgumentNullException(nameof(navigation));
    }

    public async Task InitAsync()
    {
        RejectCommand = new Command(() =>
        {
            _navigation.NavigationStack.Last().ShowPopup(new RejectPopup());
        });

        ApproveCommand = new Command(() =>
        {
            // SQL Update
        });
    }
}
