namespace AtelierBooking.Pages;

using AtelierBooking.Helpers;
using AtelierBooking.ViewModels;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;
using static AtelierBooking.DataTemplates.DataTemplates;

internal sealed class BookingListPage : ContentPage
{
    public BookingListPage()
    {
       _ = InitAsync();
    }

    private async Task InitAsync()
    {
        var vm = MauiProgram.ServiceProvider.GetRequiredService<BookingListViewModel>();
        if (vm is not null)
        {
            await vm.InitAsync(Navigation);
            BindingContext = vm;
            Content = InitPage();
        }
    }

    private View InitPage()
    {
        return new CollectionView()
        {
            MinimumHeightRequest = 150,
            ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical) { ItemSpacing = 16 },
            ItemTemplate = BookingListDataTemplate(),
            EmptyView = new Label().Text("Nič tu něje")
        }
        .Bind(CollectionView.ItemsSourceProperty, nameof(BookingListViewModel.BookTimes));
    }

}

