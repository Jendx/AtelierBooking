using AtelierBooking.Helpers;
using AtelierBooking.ViewModels;
using CommunityToolkit.Maui.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace AtelierBooking.DataTemplates
{
    internal static class DataTemplates
    {
        internal static DataTemplate BookingListDataTemplate()
        {
            return new DataTemplate(() => new Border()
            {
                Stroke = new SolidColorBrush()
                {
                    Color = Colors.DarkBlue,
                },

                Content = new Grid()
                {
                    ColumnDefinitions = Columns.Define(Star, Star),
                    RowDefinitions = Rows.Define(80, Star, Star),

                    Children =
                    {
                        Styled.BoldLabel()
                        .Bind(Label.TextProperty, "EMPTY")
                        .Row(0)
                        .Column(0),

                        Styled.BoldLabel()
                        .Bind(Label.TextProperty, "EMPTY")
                        .Row(0)
                        .Column(1),

                        new Label()
                        .Bind(Label.TextProperty, "EMPTY")
                        .Row(1)
                        .Column(0),

                        new Button()
                        .BindTapGesture(
                            nameof(BookingListViewModel.RejectCommand)
                            )
                        
                    }
                }
            });
        }
    }
}
