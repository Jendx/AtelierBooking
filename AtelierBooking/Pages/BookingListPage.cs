namespace AtelierBooking.Pages;

using AtelierBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal sealed class BookingListPage : ContentPage
{
    public BookingListPage()
    {
        _ = InitViewModel();
    }

    private async Task InitViewModel()
    {
        var vm = MauiProgram.ServiceProvider.GetRequiredService<BookingListViewModel>();

        if (vm is not null)
        {
            BindingContext = vm;
            InitPage();
        }
    }

    private View InitPage()
    {
        return new CollectionView()
        {
            ItemTemplate = DataTemplates.DataTemplates.BookingListDataTemplate()
        };
    }

}

