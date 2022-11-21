namespace AtelierBooking.Helpers;

using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Shapes;

internal static class Styled
{
    public static readonly string BoldFont = "OpenSansSemibold";
    public static readonly double SmallPadding = 6;

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

    public static Border SurroundWithBorder(this View view)
    {
        return new Border()
        {
            Stroke = new SolidColorBrush()
            {
                Color = Colors.DarkBlue,
            },

            StrokeShape = new RoundRectangle(),
            StrokeThickness = 2,

            Content = view,
        }.Paddings(left: 10, right: 10, bottom: 10);
    }
}
