namespace AtelierBooking.ViewModels;

using AtelierBooking.Http;
using AtelierBooking.Models;
using AtelierBooking.Models.CommandParameters;
using AtelierBooking.Pages.Popups;
using CommunityToolkit.Maui.Core.Extensions;
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

    public ObservableCollection<ReservationListItem> Reservations { get; private set; }

    public async Task InitAsync(INavigation navigation)
    {
        await LoadData();

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
        Reservations = (await _apiClient.GetBookTimes())
            .Select(r => r.ToReservatListItem()).ToObservableCollection();
    }
}
