namespace AtelierBooking.Helpers;

using Android.Graphics.Fonts;
using CommunityToolkit.Maui.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class Styled
{
    public static readonly string BoldFont = "OpenSansSemibold";

    public static Label BoldLabel(string text = null)
    {
        return new Label()
            .Text(text)
            .Font(family: "OpenSansSemibold", bold: true, size: 24);
    }

    public static Button RedButton(this Button button)
    {
        button.Text = "Zamítnout";
        button.BackgroundColor = Colors.Red;
        button.TextColor = Colors.White;

        return button;
    }

    public static Button GreenButton(this Button button)
    {
        button.Text = "Schválit";
        button.BackgroundColor = Colors.Green;
        button.TextColor = Colors.White;

        return button;
    }
}
