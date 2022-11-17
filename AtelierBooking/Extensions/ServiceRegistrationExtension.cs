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

            builder.Services.RegisterViewModels();

            return services;
        }

        private static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            return services
                .AddTransient<BookingListViewModel>();

        }
    }
}
