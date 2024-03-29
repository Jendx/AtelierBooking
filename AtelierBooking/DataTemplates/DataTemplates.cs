﻿namespace AtelierBooking.DataTemplates;

using AtelierBooking.Helpers;
using AtelierBooking.Models;
using AtelierBooking.ViewModels;
using CommunityToolkit.Maui.Markup;
using System;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

internal static class DataTemplates
{
    public static DataTemplate BookingListDataTemplate()
    {
        return new DataTemplate(() => new Grid()
        {
            ColumnDefinitions = Columns.Define(Star, Star),
            RowDefinitions = Rows.Define(30, Star, 40),

            RowSpacing = 6,
            ColumnSpacing = 6,

            Children =
            {
                Styled.BoldLabel()
                .Bind(
                    Label.TextProperty,
                    nameof(ReservationListItem.Name))
                .Row(0)
                .Column(0),

                Styled.BoldLabel()
                .Bind(Label.TextProperty, nameof(ReservationListItem.Date))
                .Row(0)
                .Column(1),

                new Label()
                .Bind(
                    Label.TextProperty,
                    binding1: new Binding(nameof(ReservationListItem.BookedFrom)),
                    binding2: new Binding(nameof(ReservationListItem.BookedTo)),
                    convert: ((TimeOnly bookedFrom, TimeOnly bookedTo) values) => $"{values.bookedFrom} - {values.bookedTo}")
                .Row(1)
                .Column(1),

                new Label()
                .Bind(Label.TextProperty, nameof(ReservationListItem.Contact))
                .Row(1)
                .Column(0),

                new Button()
                .BindTapGesture(
                    nameof(BookingListViewModel.RejectCommand),
                    nameof(BookingListViewModel)
                    )
                .RedButton()
                .Row(3)
                .Column(0),

                new Button()
                .BindTapGesture(
                    nameof(BookingListViewModel.ApproveCommand),
                    nameof(BookingListViewModel)
                    )
                .GreenButton()
                .Row(3)
                .Column(1),

            }
        }
        .Center()
        .FillHorizontal()
        .SurroundWithBorder());
    }
}
