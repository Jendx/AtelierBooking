namespace AtelierBooking.Helpers;

using CommunityToolkit.Maui.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class Styled
{
    public static Label BoldLabel(string text = null)
    {
        return new Label()
            .Text(text)
            .Font(bold: true, size: 16);
    }

    public static void RedButton(this Button button)
    {
        button.BackgroundColor = Colors.Red;
        button.TextColor = Colors.White;
    }
}
