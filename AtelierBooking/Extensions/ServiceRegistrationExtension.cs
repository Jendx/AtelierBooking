﻿using AtelierBooking.Http;
using AtelierBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierBooking.Extensions
{
    internal static class ServiceRegistrationExtension
    {
        internal static IServiceCollection RegisterServices(this MauiAppBuilder builder)
        {
            var services = builder.Services;

            builder.Services
                .AddSingleton<INavigation>((services) => App.Current.MainPage.Navigation)
                .AddSingleton<ApiClient>()
                .RegisterViewModels();

            return services;
        }

        private static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            return services
                .AddTransient<BookingListViewModel>();

        }
    }
}
